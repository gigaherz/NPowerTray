using System;
using System.Windows.Forms;
using NPowerTray.Properties;

namespace NPowerTray
{
    public partial class Disclaimer : Form
    {
        public Disclaimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Disclaimer_Load(object sender, EventArgs e)
        {
            Text = Resources.DisclaimerTitle;
            btnClose.Text = Resources.CloseWindow;
            rtbLicense.Rtf = Resources.Disclaimer;
        }

        private void Disclaimer_Shown(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
    }
}
