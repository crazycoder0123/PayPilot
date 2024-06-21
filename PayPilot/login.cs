using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PayPilot
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void logbt_Click(object sender, EventArgs e)
        {
            home hm = new home();
            hm.Show();
            this.Hide();
        }

        private void logforpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact to your admin for change password.", "Forgot Password?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            logpass.PasswordChar = !checkBox1.Checked ? '*' : '\0';
        }
    }
}
