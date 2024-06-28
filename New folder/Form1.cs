using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace crudsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unmtxt.Text))
            {
                MessageBox.Show("Enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                unmtxt.Focus();
            }
            else if (string.IsNullOrEmpty(pwdtxt.Text))
            {
                MessageBox.Show("Enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pwdtxt.Focus();
            }
            else
            { 
                string sql = "select * from login where unm = '" + unmtxt.Text + "'AND pwd = '" + pwdtxt.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Succesfully :)", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 home = new Form2();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check Username Or Password :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void clear()
        {
            unmtxt.Text = pwdtxt.Text = "";
            unmtxt.Focus();
        }

        public void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
