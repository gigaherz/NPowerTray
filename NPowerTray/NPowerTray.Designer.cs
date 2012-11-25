namespace NPowerTray
{
    partial class NPowerTray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPowerTray));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hybridShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specialOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceRebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceHibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceLogOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hibernateDisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepDisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceHibernateDisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceSleepDisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTrayIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.cbStartup = new System.Windows.Forms.CheckBox();
            this.lnLicense = new System.Windows.Forms.LinkLabel();
            this.lnEmail = new System.Windows.Forms.LinkLabel();
            this.cbCheckUpdates = new System.Windows.Forms.CheckBox();
            this.lnCheckNow = new System.Windows.Forms.LinkLabel();
            this.updateCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.lbDefault = new System.Windows.Forms.Label();
            this.cbDefault = new System.Windows.Forms.ComboBox();
            this.trayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "#NPowerTray (Double Click to Shutdown)";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hybridShutdownToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.rebootToolStripMenuItem,
            this.hibernateToolStripMenuItem,
            this.sleepToolStripMenuItem,
            this.separator1,
            this.lockToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.separator2,
            this.specialOptionsToolStripMenuItem,
            this.separator3,
            this.aboutToolStripMenuItem,
            this.separator4,
            this.closeTrayIconToolStripMenuItem});
            this.trayMenu.Name = "contextMenuStrip1";
            this.trayMenu.Size = new System.Drawing.Size(175, 292);
            // 
            // hybridShutdownToolStripMenuItem
            // 
            this.hybridShutdownToolStripMenuItem.Name = "hybridShutdownToolStripMenuItem";
            this.hybridShutdownToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hybridShutdownToolStripMenuItem.Text = "#Hybrid Shutdown";
            this.hybridShutdownToolStripMenuItem.Click += new System.EventHandler(this.hybridShutdownToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownToolStripMenuItem.Image = global::NPowerTray.Properties.Resources.npower16;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.shutdownToolStripMenuItem.Text = "#Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // rebootToolStripMenuItem
            // 
            this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            this.rebootToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rebootToolStripMenuItem.Text = "#Reboot";
            this.rebootToolStripMenuItem.Click += new System.EventHandler(this.rebootToolStripMenuItem_Click);
            // 
            // hibernateToolStripMenuItem
            // 
            this.hibernateToolStripMenuItem.Name = "hibernateToolStripMenuItem";
            this.hibernateToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hibernateToolStripMenuItem.Text = "#Hibernate";
            this.hibernateToolStripMenuItem.Click += new System.EventHandler(this.hibernateToolStripMenuItem_Click);
            // 
            // sleepToolStripMenuItem
            // 
            this.sleepToolStripMenuItem.Name = "sleepToolStripMenuItem";
            this.sleepToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sleepToolStripMenuItem.Text = "#Sleep";
            this.sleepToolStripMenuItem.Click += new System.EventHandler(this.sleepToolStripMenuItem_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(171, 6);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.lockToolStripMenuItem.Text = "#Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.logOffToolStripMenuItem.Text = "#Log Off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.changeUserToolStripMenuItem.Text = "#Change User";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(171, 6);
            // 
            // specialOptionsToolStripMenuItem
            // 
            this.specialOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceShutdownToolStripMenuItem,
            this.forceRebootToolStripMenuItem,
            this.forceHibernateToolStripMenuItem,
            this.forceSleepToolStripMenuItem,
            this.forceLogOffToolStripMenuItem,
            this.separator5,
            this.hibernateDisableWakeUpEventsToolStripMenuItem,
            this.sleepDisableWakeUpEventsToolStripMenuItem,
            this.forceHibernateDisableWakeUpEventsToolStripMenuItem,
            this.forceSleepDisableWakeUpEventsToolStripMenuItem});
            this.specialOptionsToolStripMenuItem.Name = "specialOptionsToolStripMenuItem";
            this.specialOptionsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.specialOptionsToolStripMenuItem.Text = "#Special Options";
            // 
            // forceShutdownToolStripMenuItem
            // 
            this.forceShutdownToolStripMenuItem.Name = "forceShutdownToolStripMenuItem";
            this.forceShutdownToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceShutdownToolStripMenuItem.Text = "#Force Shutdown";
            this.forceShutdownToolStripMenuItem.Click += new System.EventHandler(this.forceShutdownToolStripMenuItem_Click);
            // 
            // forceRebootToolStripMenuItem
            // 
            this.forceRebootToolStripMenuItem.Name = "forceRebootToolStripMenuItem";
            this.forceRebootToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceRebootToolStripMenuItem.Text = "#Force Reboot";
            this.forceRebootToolStripMenuItem.Click += new System.EventHandler(this.forceRebootToolStripMenuItem_Click);
            // 
            // forceHibernateToolStripMenuItem
            // 
            this.forceHibernateToolStripMenuItem.Name = "forceHibernateToolStripMenuItem";
            this.forceHibernateToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceHibernateToolStripMenuItem.Text = "#Force Hibernate";
            this.forceHibernateToolStripMenuItem.Click += new System.EventHandler(this.forceHibernateToolStripMenuItem_Click);
            // 
            // forceSleepToolStripMenuItem
            // 
            this.forceSleepToolStripMenuItem.Name = "forceSleepToolStripMenuItem";
            this.forceSleepToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceSleepToolStripMenuItem.Text = "#Force Sleep";
            this.forceSleepToolStripMenuItem.Click += new System.EventHandler(this.forceSleepToolStripMenuItem_Click);
            // 
            // forceLogOffToolStripMenuItem
            // 
            this.forceLogOffToolStripMenuItem.Name = "forceLogOffToolStripMenuItem";
            this.forceLogOffToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceLogOffToolStripMenuItem.Text = "#Force Log Off";
            this.forceLogOffToolStripMenuItem.Click += new System.EventHandler(this.forceLogOffToolStripMenuItem_Click);
            // 
            // separator5
            // 
            this.separator5.Name = "separator5";
            this.separator5.Size = new System.Drawing.Size(294, 6);
            // 
            // hibernateDisableWakeUpEventsToolStripMenuItem
            // 
            this.hibernateDisableWakeUpEventsToolStripMenuItem.Name = "hibernateDisableWakeUpEventsToolStripMenuItem";
            this.hibernateDisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.hibernateDisableWakeUpEventsToolStripMenuItem.Text = "#Hibernate (disable WakeUp Events)";
            this.hibernateDisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.hibernatedisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // sleepDisableWakeUpEventsToolStripMenuItem
            // 
            this.sleepDisableWakeUpEventsToolStripMenuItem.Name = "sleepDisableWakeUpEventsToolStripMenuItem";
            this.sleepDisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.sleepDisableWakeUpEventsToolStripMenuItem.Text = "#Sleep (disable WakeUp Events)";
            this.sleepDisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.sleepdisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // forceHibernateDisableWakeUpEventsToolStripMenuItem
            // 
            this.forceHibernateDisableWakeUpEventsToolStripMenuItem.Name = "forceHibernateDisableWakeUpEventsToolStripMenuItem";
            this.forceHibernateDisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceHibernateDisableWakeUpEventsToolStripMenuItem.Text = "#Force Hibernate (disable WakeUp Events)";
            this.forceHibernateDisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.forceHibernatedisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // forceSleepDisableWakeUpEventsToolStripMenuItem
            // 
            this.forceSleepDisableWakeUpEventsToolStripMenuItem.Name = "forceSleepDisableWakeUpEventsToolStripMenuItem";
            this.forceSleepDisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceSleepDisableWakeUpEventsToolStripMenuItem.Text = "#Force Sleep (disable WakeUp Events)";
            this.forceSleepDisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.forceSleepdisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(171, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutToolStripMenuItem.Text = "#About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            this.separator4.Size = new System.Drawing.Size(171, 6);
            // 
            // closeTrayIconToolStripMenuItem
            // 
            this.closeTrayIconToolStripMenuItem.Name = "closeTrayIconToolStripMenuItem";
            this.closeTrayIconToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeTrayIconToolStripMenuItem.Text = "#Close Tray Icon";
            this.closeTrayIconToolStripMenuItem.Click += new System.EventHandler(this.closeTrayIconToolStripMenuItem_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::NPowerTray.Properties.Resources.npower48;
            this.picIcon.Location = new System.Drawing.Point(12, 10);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(48, 48);
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(66, 10);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(150, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "#Copyright: © David Quintana";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(66, 27);
            this.lblContact.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(54, 13);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "#Contact:";
            // 
            // cbStartup
            // 
            this.cbStartup.AutoSize = true;
            this.cbStartup.Location = new System.Drawing.Point(12, 62);
            this.cbStartup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.cbStartup.Name = "cbStartup";
            this.cbStartup.Size = new System.Drawing.Size(167, 17);
            this.cbStartup.TabIndex = 5;
            this.cbStartup.Text = "#Start with Windows Desktop";
            this.cbStartup.UseVisualStyleBackColor = true;
            this.cbStartup.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lnLicense
            // 
            this.lnLicense.AutoSize = true;
            this.lnLicense.Location = new System.Drawing.Point(66, 44);
            this.lnLicense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lnLicense.Name = "lnLicense";
            this.lnLicense.Size = new System.Drawing.Size(81, 13);
            this.lnLicense.TabIndex = 6;
            this.lnLicense.TabStop = true;
            this.lnLicense.Text = "#License Info...";
            this.lnLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnEmail
            // 
            this.lnEmail.AutoSize = true;
            this.lnEmail.Location = new System.Drawing.Point(113, 27);
            this.lnEmail.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.lnEmail.Name = "lnEmail";
            this.lnEmail.Size = new System.Drawing.Size(112, 13);
            this.lnEmail.TabIndex = 7;
            this.lnEmail.TabStop = true;
            this.lnEmail.Text = "#gigaherz@gmail.com";
            this.lnEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cbCheckUpdates
            // 
            this.cbCheckUpdates.AutoSize = true;
            this.cbCheckUpdates.Location = new System.Drawing.Point(12, 79);
            this.cbCheckUpdates.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cbCheckUpdates.Name = "cbCheckUpdates";
            this.cbCheckUpdates.Size = new System.Drawing.Size(120, 17);
            this.cbCheckUpdates.TabIndex = 8;
            this.cbCheckUpdates.Text = "#Check for updates";
            this.cbCheckUpdates.UseVisualStyleBackColor = true;
            this.cbCheckUpdates.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lnCheckNow
            // 
            this.lnCheckNow.AutoSize = true;
            this.lnCheckNow.Location = new System.Drawing.Point(131, 80);
            this.lnCheckNow.Name = "lnCheckNow";
            this.lnCheckNow.Size = new System.Drawing.Size(75, 13);
            this.lnCheckNow.TabIndex = 9;
            this.lnCheckNow.TabStop = true;
            this.lnCheckNow.Text = "#Check NOW";
            this.lnCheckNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // updateCheckTimer
            // 
            this.updateCheckTimer.Enabled = true;
            this.updateCheckTimer.Interval = 600000;
            this.updateCheckTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDefault
            // 
            this.lbDefault.AutoSize = true;
            this.lbDefault.Location = new System.Drawing.Point(12, 99);
            this.lbDefault.Name = "lbDefault";
            this.lbDefault.Size = new System.Drawing.Size(80, 13);
            this.lbDefault.TabIndex = 10;
            this.lbDefault.Text = "#Default action";
            // 
            // cbDefault
            // 
            this.cbDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefault.FormattingEnabled = true;
            this.cbDefault.Location = new System.Drawing.Point(92, 96);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(121, 21);
            this.cbDefault.TabIndex = 11;
            this.cbDefault.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NPowerTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 129);
            this.Controls.Add(this.cbDefault);
            this.Controls.Add(this.lbDefault);
            this.Controls.Add(this.lnCheckNow);
            this.Controls.Add(this.cbCheckUpdates);
            this.Controls.Add(this.lnEmail);
            this.Controls.Add(this.lnLicense);
            this.Controls.Add(this.cbStartup);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NPowerTray";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "#About NPowerTray...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NPowerTray_FormClosing);
            this.Load += new System.EventHandler(this.NPowerTray_Load);
            this.Shown += new System.EventHandler(this.NPowerTray_Shown);
            this.VisibleChanged += new System.EventHandler(this.NPowerTray_VisibleChanged);
            this.trayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator3;
        private System.Windows.Forms.ToolStripMenuItem closeTrayIconToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ToolStripMenuItem hibernateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator4;
        private System.Windows.Forms.CheckBox cbStartup;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripMenuItem specialOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceRebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceHibernateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceSleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceLogOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator5;
        private System.Windows.Forms.ToolStripMenuItem hibernateDisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepDisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceHibernateDisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceSleepDisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnLicense;
        private System.Windows.Forms.LinkLabel lnEmail;
        private System.Windows.Forms.CheckBox cbCheckUpdates;
        private System.Windows.Forms.LinkLabel lnCheckNow;
        private System.Windows.Forms.Timer updateCheckTimer;
        private System.Windows.Forms.Label lbDefault;
        private System.Windows.Forms.ComboBox cbDefault;
        private System.Windows.Forms.ToolStripMenuItem hybridShutdownToolStripMenuItem;
    }
}

