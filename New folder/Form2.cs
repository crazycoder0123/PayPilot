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
using System.Xml.Linq;
using System.Xml;

namespace crudsql
{
    public partial class Form2 : Form
    {
        string id = string.Empty;
        int tr = 0;
        int rp = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewfunc();
        }
        private void empadd_Click(object sender, EventArgs e)
        {
            if (Notnullfunc() == true)
            {
                if (IsIdUnique(empid.Text))
                {
                    string sql = "insert into emp values('" + empid.Text + "','" + dept.Text + "','" + empnm.Text + "','" + jdate.Text + "','" + salary.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Employee Add Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewfunc();
                }
                else
                {
                    MessageBox.Show("Something Wrong..");
                }
            }
        }
        void viewfunc()
        {
            string sql = "select * from emp";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private bool Notnullfunc()
        {
            if (string.IsNullOrEmpty(empid.Text))
            {
                MessageBox.Show("ID is blank", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(empnm.Text))
            {
                MessageBox.Show("Name is blank", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(dept.Text))
            {
                MessageBox.Show("deparrtment is blank", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (string.IsNullOrEmpty(salary.Text))
            {
                MessageBox.Show("salary is blank", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsIdUnique(string empId)
        {
            string sql = "SELECT empid FROM emp";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow[] rows = dt.Select("empid = '" + empId + "'");
            return rows.Length == 0;
        }

        private void empdelete_Click(object sender, EventArgs e)
        {
            if (Notnullfunc() == true)
            {
                string sql = "delete from emp where empid='" +
                empid.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Employee Delete Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewfunc();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                empid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dept.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                empnm.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                jdate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                salary.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }


        private void empedit_Click(object sender, EventArgs e)
        {
            if (Notnullfunc() == true)
            {
                string sql = "update emp set empid='" + empid.Text + "',dept='" + dept.Text + "',empname='" + empnm.Text + "',jdate='" + jdate.Text + "',salary='" + salary.Text + "' where empid='" + empid.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("data upadated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewfunc();
                
            }
            else
            {
                MessageBox.Show("Something Wrong...");
            }
        }
    }
}

