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
    public partial class frmsrsi : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=KKN\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");


        public frmsrsi()
        {
            InitializeComponent();
            loadUsers();
        }

        public void loadUsers()
        {

            try
            {
                con.Open();
                string query = "SELECT regNo from Registration;";
                SqlCommand cmnd = new SqlCommand(query, con);
                SqlDataReader result = cmnd.ExecuteReader();

                cmbbxrn.Items.Clear();

                while (result.Read())
                {
                    cmbbxrn.Items.Add(result["regNo"]);
                }

                con.Close();
            }
            catch (Exception en)
            {
                Console.WriteLine(en);
            }
            
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KKN\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

            try
            {
                string firstName = txtfn.Text;
                string lastName = txtln.Text;
                dateTimePickerdob.Format = DateTimePickerFormat.Custom;
                dateTimePickerdob.CustomFormat = "yyyy/MM/dd";
                string gender;
                if (radioButtonm.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtaddr.Text;
                string email = txteml.Text;
                int mobilePhone = int.Parse(txtmp.Text);
                int homePhone = int.Parse(txthp.Text);
                string parentName = txtpn.Text;
                string nic = txtnic.Text;
                int contactNumber = int.Parse(txtcn.Text);
                string query_insert = "insert into Registration values('" + firstName + "','" + lastName + "','" + dateTimePickerdob.Text + "','" + gender + "','" + address + "','" + email + "','" + mobilePhone + "','" + homePhone + "','" + parentName + "','" + nic + "'," + contactNumber + ")";

                try
                {
                    con.Open();

                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    
                }
                catch(Exception en)
                {
                    Console.WriteLine(en);
                }
                MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                MessageBox.Show(msg);
            }

            clearAndUpdate();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KKN\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

            
                string firstName = txtfn.Text;
                string lastName = txtln.Text;
                string no = cmbbxrn.Text;
                dateTimePickerdob.Format = DateTimePickerFormat.Custom;
                dateTimePickerdob.CustomFormat = "yyyy/MM/dd";
                string gender;
                if (radioButtonm.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtaddr.Text;
                string email = txteml.Text;
                int mobilePhone = int.Parse(txtmp.Text);
                int homePhone = int.Parse(txthp.Text);
                string parentName = txtpn.Text;
                string nic = txtnic.Text;
                int contactNumber = int.Parse(txtcn.Text);

                string query_insert = "UPDATE Registration SET firstName = '" + firstName + "',lastName ='" + lastName + "',dateOfBirth ='" + dateTimePickerdob.Text + "', gender = '" + gender + "', address = '" + address + "', email = '" + email + "', mobilePhone = '" + mobilePhone + "', homePhone = '" + homePhone + "', parentName = '" + parentName + "', nic = '" + nic + "', contactNo = " + contactNumber + "WHERE regNo="+no;

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearAndUpdate();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            clearAndUpdate();
        }
        

        private void clearAndUpdate()
        {
            cmbbxrn.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            dateTimePickerdob.Format = DateTimePickerFormat.Custom;
            dateTimePickerdob.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dateTimePickerdob.Text = thisDay.ToString();

            radioButtonm.Checked = false;
            radioButtonfm.Checked = false;

            txtaddr.Text = "";
            txteml.Text = "";
            txtmp.Text = "";
            txthp.Text = "";
            txtpn.Text = "";
            txtnic.Text = "";
            txtcn.Text = "";

            loadUsers();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KKN\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

            var result = MessageBox.Show("Are you sure,Do you really want to Delete this Record...?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string no = cmbbxrn.Text;


                string query_insert = "DELETE FROM Registration WHERE regNo=" + no + "";
                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Record Deleted successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }

            clearAndUpdate();
        }

        private void lnklbllgout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsilogin obj = new frmsilogin();
            obj.Show();
            this.Close();
        }

        private void lnklblext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbbxrn_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedUserReg = cmbbxrn.Text;

            con.Open();
            string query = "SELECT * from Registration WHERE regNo='" + selectedUserReg + "';";
            SqlCommand cmnd = new SqlCommand(query, con);
            SqlDataReader result = cmnd.ExecuteReader();
            while (result.Read())
            {
                txtfn.Text = result["firstName"].ToString();
                txtln.Text = result["lastName"].ToString();
                dateTimePickerdob.Value = (DateTime)result["dateOfBirth"];

                bool male = ((string)result["gender"] == "Male") ? true : false;
                radioButtonfm.Checked = !male;
                radioButtonm.Checked = male;

                txtaddr.Text = result["address"].ToString();
                txteml.Text = result["email"].ToString();
                txthp.Text = result["homePhone"].ToString();
                txtmp.Text = result["mobilePhone"].ToString();
                txtpn.Text = result["parentName"].ToString();
                txtnic.Text = result["nic"].ToString();
                txtcn.Text = result["contactNo"].ToString();

            }
            con.Close();
        }
    }
}
