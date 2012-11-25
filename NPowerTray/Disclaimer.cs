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

            button1.Text = Resources.CloseWindow;
            Text = Resources.DisclaimerTitle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Disclaimer_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = Resources.Disclaimer;
        }

        private void Disclaimer_Shown(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
