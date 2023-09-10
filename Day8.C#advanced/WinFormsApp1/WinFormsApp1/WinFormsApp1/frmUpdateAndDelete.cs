using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmUpdateAndDelete : Form
    {
        public frmUpdateAndDelete()
        {

            InitializeComponent();
            //  FillEmployeesList();
            FillEmployeeList();

        }



        private void FillEmployeeList()
        {
            SqlConnection con = new SqlConnection("Data source=.;initial catalog=Company_SD;integrated security=true;trustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select SSN, Emp_Fname + ' ' + Emp_Lname as FullName  from dbo.Employee";

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);


                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "FullName";
                comboBox1.ValueMember = "SSN";
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                throw;
            }
            finally { con.Close(); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ssn = comboBox1.SelectedValue.ToString();
            SqlConnection con = new SqlConnection("Data source=.;initial catalog=Company_SD;integrated security=true;trustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select*from employee where ssn =@ID";
            command.Parameters.AddWithValue("@ID", ssn);

            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                ///
                txtID.Text = dt.Rows[0]["SSN"].ToString();
                txtFname.Text = dt.Rows[0]["Emp_Fname"].ToString();
                txtLname.Text = dt.Rows[0]["Emp_Lname"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtID.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=.;initial catalog=Company_SD;integrated security=true;trustServerCertificate=true");

            SqlCommand command = new SqlCommand();

            command.CommandText = "update employee set emp_Fname=@Fname,Emp_Lname=@Lname,Address=@Address where SSN=@ID";
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Fname", txtFname.Text);
            command.Parameters.AddWithValue("@Lname", txtLname.Text);
            command.Parameters.AddWithValue("@Address", txtAddress.Text);

            command.Connection = con;

            try
            {
                con.Open();
                label5.Text = $"{command.ExecuteNonQuery()} Rows Affected";
                FillEmployeeList();

            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var name = comboBox1.Text;
            if (MessageBox.Show($"R U sure Deleting {name} !!!", "Warning!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var ssn = comboBox1.SelectedValue.ToString();
                SqlConnection con = new SqlConnection("Data source=.;initial catalog=Company_SD;integrated security=true;trustServerCertificate=true");

                SqlCommand command = new SqlCommand();

                command.CommandText = "delete from Employee where SSN=@ID";
                command.Parameters.AddWithValue("@ID", ssn);

                command.Connection = con;

                try
                {
                    con.Open();

                    label5.Text = $"{command.ExecuteNonQuery()} Rows Deleted !!!";

                    FillEmployeeList();

                }
                catch (Exception)
                {

                    throw;
                }
                finally { con.Close(); }
            }
        }
    }
}
