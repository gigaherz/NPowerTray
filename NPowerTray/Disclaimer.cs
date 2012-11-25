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

            btnClose.Text = Resources.CloseWindow;
            Text = Resources.DisclaimerTitle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Disclaimer_Load(object sender, EventArgs e)
        {
            rtbLicense.Rtf = Resources.Disclaimer;
        }

        private void Disclaimer_Shown(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
    }
}
