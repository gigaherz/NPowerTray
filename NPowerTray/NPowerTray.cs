using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NPowerTray.Properties;

namespace NPowerTray
{
    public partial class NPowerTray : Form
    {
        private bool actuallyClosing;
        private bool everShown;
        private Size savedSize;

        readonly Font boldFont;
        readonly Font normalFont;

        class ItemValue
        {
            public DefaultActions Action { get; private set; }
            public string Text { get; private set; }

            public ItemValue(DefaultActions action, string text)
            {
                Action = action;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private ItemValue currentDefaultAction;

        public NPowerTray()
        {
            InitializeComponent();

            boldFont = shutdownToolStripMenuItem.Font;
            normalFont = rebootToolStripMenuItem.Font;
            var osv = Environment.OSVersion;
            var isWin8 = (osv.Platform == PlatformID.Win32NT &&
                          osv.Version >= new Version(6, 2));

            hybridShutdownToolStripMenuItem.Visible = isWin8;

            shutdownToolStripMenuItem.Text = Resources.ActionShutdown;
            rebootToolStripMenuItem.Text = Resources.ActionReboot;
            hibernateToolStripMenuItem.Text = Resources.ActionHibernate;
            sleepToolStripMenuItem.Text = Resources.ActionSleep;
            lockToolStripMenuItem.Text = Resources.ActionLock;
            logOffToolStripMenuItem.Text = Resources.ActionLogOff;
            changeUserToolStripMenuItem.Text = Resources.ActionChangeUser;
            specialOptionsToolStripMenuItem.Text = Resources.MenuSpecialOptions;
            forceShutdownToolStripMenuItem.Text = Resources.ActionForceShutdown;
            forceRebootToolStripMenuItem.Text = Resources.ActionForceReboot;
            forceHibernateToolStripMenuItem.Text = Resources.ActionForceHibernate;
            forceSleepToolStripMenuItem.Text = Resources.ActionForceSleep;
            forceLogOffToolStripMenuItem.Text = Resources.ActionForceLogOff;
            hibernateDisableWakeUpEventsToolStripMenuItem.Text = Resources.ActionHibernateDisableWakeupEvents;
            sleepDisableWakeUpEventsToolStripMenuItem.Text = Resources.ActionSleepDisableWakeupEvents;
            forceHibernateDisableWakeUpEventsToolStripMenuItem.Text = Resources.ActionForceHibernateDisableWakeupEvents;
            forceSleepDisableWakeUpEventsToolStripMenuItem.Text = Resources.ActionForceSleepDisableWakeupEvents;
            aboutToolStripMenuItem.Text = Resources.ShowAbout;
            closeTrayIconToolStripMenuItem.Text = Resources.CloseTrayIcon;
            lblCopyright.Text = Resources.CopyrightNotice;
            lblContact.Text = Resources.Contact;
            cbStartup.Text = Resources.Startup;
            lnLicense.Text = Resources.ShowLicense;
            lnEmail.Text = Program.AuthorEmail;
            cbCheckUpdates.Text = Resources.CheckForUpdates;
            lnCheckNow.Text = Resources.CheckNow;
            lbDefault.Text = Resources.DefaultActionChoice;

            cbDefault.Items.Clear();

            if (isWin8)
                cbDefault.Items.Add(
                    new ItemValue(DefaultActions.HybridShutdown, Resources.ActionHybridShutdown));
            cbDefault.Items.AddRange(new object[]
                {
                    new ItemValue(DefaultActions.Shutdown, Resources.ActionShutdown),
                    new ItemValue(DefaultActions.Reboot, Resources.ActionReboot),
                    new ItemValue(DefaultActions.Sleep, Resources.ActionSleep),
                    new ItemValue(DefaultActions.Hibernate, Resources.ActionHibernate),
                    new ItemValue(DefaultActions.Lock, Resources.ActionLock),
                    new ItemValue(DefaultActions.LogOff, Resources.ActionLogOff),
                    new ItemValue(DefaultActions.ChangeUser, Resources.ActionChangeUser)
                });
            
            hybridShutdownToolStripMenuItem.Text = Resources.ActionHybridShutdown;
            Text = Resources.AboutBoxTitle;

            // ///////////////////////////////////////////////////////////////////////////////////// //
            // Sanitize settings

            var defStr = RegistrySettings.GetConfig(RegistrySettings.ConfigKey.DefaultAction, "Shutdown");
            defStr = defStr.Replace(" ", "");

            DefaultActions def;
            if(!Enum.TryParse(defStr, out def))
            {
                def = DefaultActions.Shutdown;
            }

            if(defStr != def.ToString())
                RegistrySettings.SetConfig(RegistrySettings.ConfigKey.DefaultAction, def.ToString());

            // ///////////////////////////////////////////////////////////////////////////////////// //

            var defItem = cbDefault.Items.Cast<ItemValue>().FirstOrDefault(item => item.Action == def);

            if (defItem == null)
                return;

            currentDefaultAction = defItem;

            trayIcon.Text = string.Format(Resources.TrayIconTooltip, currentDefaultAction.Text);
        }

        #region Dialog Events
        private void NPowerTray_Load(object sender, EventArgs e)
        {
            savedSize = Size;
        }

        private void NPowerTray_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing || actuallyClosing) 
                return;

            e.Cancel = true;
            Hide();
        }

        private void NPowerTray_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible) 
                return;

            cbStartup.Checked = PowerActions.StartupState;
            cbCheckUpdates.Checked = Updates.CheckPeriodically;

            var def = (DefaultActions)Enum.Parse(typeof(DefaultActions), RegistrySettings.GetConfig(RegistrySettings.ConfigKey.DefaultAction, "Shutdown"));

            ItemValue defItem = null;
            for (var i = 0; i < cbDefault.Items.Count; i++)
            {
                var item = (ItemValue)cbDefault.Items[i];
                
                if (item.Action != def) 
                    continue;

                cbDefault.SelectedIndex = i;
                defItem = item;
            }

            if (defItem == null)
                return;

            foreach(var item in trayMenu.Items.OfType<ToolStripMenuItem>())
            {
                item.Font = (item.Text == defItem.Text) ? boldFont : normalFont;
            }

            var sz = Screen.GetWorkingArea(Location).Size;
            var loc = new Point(sz.Width - savedSize.Width - 8, sz.Height - savedSize.Height - 8);

            SetBounds(loc.X, loc.Y, savedSize.Width, savedSize.Height);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            PowerActions.StartupState = cbStartup.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Updates.CheckPeriodically = cbCheckUpdates.Checked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(string.Format("mailto:{0}", Program.AuthorEmail));
            lnEmail.LinkVisited = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoCheckForUpdates();
            lnCheckNow.LinkVisited = true;
        }

        private static void DoCheckForUpdates()
        {
            int[] newVersion;

            if (!Updates.CheckForUpdates(out newVersion)) 
                return;

            if (MessageBox.Show(
                string.Format(Resources.NewVersionMessage,
                              string.Join(".", newVersion)),
                Resources.UpdatesTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Process.Start(Program.ProgramUrl);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Updates.AutoCheck())
                DoCheckForUpdates();
        }

        private void NPowerTray_Shown(object sender, EventArgs e)
        {
            everShown = true;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var iv = cbDefault.SelectedItem as ItemValue;

            currentDefaultAction = iv;

            if (iv == null)
                return;

            trayIcon.Text = string.Format(Resources.TrayIconTooltip, currentDefaultAction.Text);

            RegistrySettings.SetConfig(RegistrySettings.ConfigKey.DefaultAction, iv.Action.ToString());
            NPowerTray_VisibleChanged(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Disclaimer()).ShowDialog(this);
            lnLicense.LinkVisited = true;
        }
        #endregion

        #region Misc Menu Items
        private void closeTrayIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actuallyClosing = true;

            // begin FIXME: The FormClose event doesn't fire if the window has never been shown!
            if (!everShown)
            {
                WindowState = FormWindowState.Minimized;
                Show();
            }
            // end

            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }
        #endregion

        #region Tray Icon and Menu
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            var def = (DefaultActions)Enum.Parse(typeof(DefaultActions), RegistrySettings.GetConfig(RegistrySettings.ConfigKey.DefaultAction, "Shutdown"));

            switch (def)
            {
                case DefaultActions.HybridShutdown:
                    hybridShutdownToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.Shutdown:
                    shutdownToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.Reboot:
                    rebootToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.Sleep:
                    sleepToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.Hibernate:
                    hibernateToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.Lock:
                    lockToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.LogOff:
                    logOffToolStripMenuItem.PerformClick();
                    break;
                case DefaultActions.ChangeUser:
                    changeUserToolStripMenuItem.PerformClick();
                    break;
            }
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Shutdown(ShutdownMode.Shutdown);
        }

        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Shutdown(ShutdownMode.Reboot);
        }

        private void hibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Hibernate);
        }

        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Suspend);
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Shutdown(ShutdownMode.LogOff);
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Lock();
        }

        private void forceShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Shutdown(ShutdownMode.ForceShutdown);
        }

        private void forceRebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Shutdown(ShutdownMode.ForceReboot);
        }

        private void forceHibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Hibernate, true);
        }

        private void forceSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Suspend, true);
        }

        private void forceLogOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.Shutdown(ShutdownMode.ForceLogOff);
        }

        private void hibernatedisableWakeUpEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Hibernate, false, true);
        }

        private void sleepdisableWakeUpEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Suspend, false, true);
        }

        private void forceHibernatedisableWakeUpEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Hibernate, true, true);
        }

        private void forceSleepdisableWakeUpEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.SetPowerState(PowerState.Suspend, true, true);
        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.FastUserSwitch();
        }

        private void hybridShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PowerActions.ShutdownHybrid();
        }
        #endregion
    }
}
