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

        public NPowerTray()
        {
            InitializeComponent();
            boldFont = shutdownToolStripMenuItem.Font;
            normalFont = rebootToolStripMenuItem.Font;

            var osv = Environment.OSVersion;
            var isWin8 = (osv.Platform == PlatformID.Win32NT &&
                          osv.Version >= new Version(6, 2));
            hybridShutdownToolStripMenuItem.Visible = isWin8;

            if(isWin8)
            {
                comboBox1.Items.Insert(0, "Hybrid Shutdown");
            }
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

            checkBox1.Checked = PowerActions.StartupState;
            checkBox2.Checked = Updates.CheckPeriodically;

            var def = RegistrySettings.GetConfig(RegistrySettings.ConfigKey.DefaultAction, "Shutdown");

            comboBox1.SelectedItem = def;
            foreach(var item in contextMenuStrip1.Items.OfType<ToolStripMenuItem>())
            {
                item.Font = (item.Text == def) ? boldFont : normalFont;
            }

            var sz = Screen.GetWorkingArea(Location).Size;
            var loc = new Point(sz.Width - savedSize.Width - 8, sz.Height - savedSize.Height - 8);

            SetBounds(loc.X, loc.Y, savedSize.Width, savedSize.Height);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            PowerActions.StartupState = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Updates.CheckPeriodically = checkBox2.Checked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(string.Format("mailto:{0}", Program.AuthorEmail));
            linkLabel2.LinkVisited = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoCheckForUpdates();
            linkLabel3.LinkVisited = true;
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
            RegistrySettings.SetConfig(RegistrySettings.ConfigKey.DefaultAction, (string)comboBox1.SelectedItem);
            NPowerTray_VisibleChanged(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Disclaimer()).ShowDialog(this);
            linkLabel1.LinkVisited = true;
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
            switch (RegistrySettings.GetConfig(RegistrySettings.ConfigKey.DefaultAction, "Shutdown"))
            {
                case "Hybrid Shutdown":
                    hybridShutdownToolStripMenuItem.PerformClick();
                    break;
                case "Shutdown":
                    shutdownToolStripMenuItem.PerformClick();
                    break;
                case "Reboot":
                    rebootToolStripMenuItem.PerformClick();
                    break;
                case "Sleep":
                    sleepToolStripMenuItem.PerformClick();
                    break;
                case "Hibernate":
                    hibernateToolStripMenuItem.PerformClick();
                    break;
                case "Lock":
                    lockToolStripMenuItem.PerformClick();
                    break;
                case "Log off":
                    logOffToolStripMenuItem.PerformClick();
                    break;
                case "Change User":
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
