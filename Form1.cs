using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project_E162561
{
    public partial class frmsilogin : Form
    {
        public frmsilogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=KKN\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtun.Clear();
            txtpw.Clear();
            txtun.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();

            string username = txtun.Text;
            string pass = txtpw.Text;

            string query_select = "SELECT * FROM Logins WHERE username ='" + username + "'AND password='" + pass + "'";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();

            if(row.HasRows)
            {
                this.Hide();
                frmsrsi obj = new frmsrsi();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials, Please check Username & Password and try again ", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkbxsp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxsp.Checked)
            {
                txtpw.UseSystemPasswordChar = false;
            }
            else
            {
                txtpw.UseSystemPasswordChar = true;
            }
        }
    }
}
