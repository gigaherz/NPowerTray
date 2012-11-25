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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hybridShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.specialOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceRebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceHibernateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceLogOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.hibernatedisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepdisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceHibernatedisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceSleepdisableWakeUpEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTrayIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "#NPowerTray (Double Click to Shutdown)";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hybridShutdownToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.rebootToolStripMenuItem,
            this.hibernateToolStripMenuItem,
            this.sleepToolStripMenuItem,
            this.toolStripMenuItem1,
            this.lockToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.toolStripMenuItem5,
            this.specialOptionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeTrayIconToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 270);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(171, 6);
            // 
            // specialOptionsToolStripMenuItem
            // 
            this.specialOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceShutdownToolStripMenuItem,
            this.forceRebootToolStripMenuItem,
            this.forceHibernateToolStripMenuItem,
            this.forceSleepToolStripMenuItem,
            this.forceLogOffToolStripMenuItem,
            this.toolStripMenuItem4,
            this.hibernatedisableWakeUpEventsToolStripMenuItem,
            this.sleepdisableWakeUpEventsToolStripMenuItem,
            this.forceHibernatedisableWakeUpEventsToolStripMenuItem,
            this.forceSleepdisableWakeUpEventsToolStripMenuItem});
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
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(294, 6);
            // 
            // hibernatedisableWakeUpEventsToolStripMenuItem
            // 
            this.hibernatedisableWakeUpEventsToolStripMenuItem.Name = "hibernatedisableWakeUpEventsToolStripMenuItem";
            this.hibernatedisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.hibernatedisableWakeUpEventsToolStripMenuItem.Text = "#Hibernate (disable WakeUp Events)";
            this.hibernatedisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.hibernatedisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // sleepdisableWakeUpEventsToolStripMenuItem
            // 
            this.sleepdisableWakeUpEventsToolStripMenuItem.Name = "sleepdisableWakeUpEventsToolStripMenuItem";
            this.sleepdisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.sleepdisableWakeUpEventsToolStripMenuItem.Text = "#Sleep (disable WakeUp Events)";
            this.sleepdisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.sleepdisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // forceHibernatedisableWakeUpEventsToolStripMenuItem
            // 
            this.forceHibernatedisableWakeUpEventsToolStripMenuItem.Name = "forceHibernatedisableWakeUpEventsToolStripMenuItem";
            this.forceHibernatedisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceHibernatedisableWakeUpEventsToolStripMenuItem.Text = "#Force Hibernate (disable WakeUp Events)";
            this.forceHibernatedisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.forceHibernatedisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // forceSleepdisableWakeUpEventsToolStripMenuItem
            // 
            this.forceSleepdisableWakeUpEventsToolStripMenuItem.Name = "forceSleepdisableWakeUpEventsToolStripMenuItem";
            this.forceSleepdisableWakeUpEventsToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.forceSleepdisableWakeUpEventsToolStripMenuItem.Text = "#Force Sleep (disable WakeUp Events)";
            this.forceSleepdisableWakeUpEventsToolStripMenuItem.Click += new System.EventHandler(this.forceSleepdisableWakeUpEventsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutToolStripMenuItem.Text = "#About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // closeTrayIconToolStripMenuItem
            // 
            this.closeTrayIconToolStripMenuItem.Name = "closeTrayIconToolStripMenuItem";
            this.closeTrayIconToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeTrayIconToolStripMenuItem.Text = "#Close Tray Icon";
            this.closeTrayIconToolStripMenuItem.Click += new System.EventHandler(this.closeTrayIconToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NPowerTray.Properties.Resources.npower48;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "#Copyright: © David Quintana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "#Contact:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 62);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "#Start with Windows Desktop";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(66, 44);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "#License Info...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(113, 27);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "#gigaherz@gmail.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 79);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "#Check for updates";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(131, 80);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(75, 13);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "#Check NOW";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "#Default action";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NPowerTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 129);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeTrayIconToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem hibernateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem specialOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceRebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceHibernateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceSleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceLogOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hibernatedisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepdisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceHibernatedisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceSleepdisableWakeUpEventsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem hybridShutdownToolStripMenuItem;
    }
}

