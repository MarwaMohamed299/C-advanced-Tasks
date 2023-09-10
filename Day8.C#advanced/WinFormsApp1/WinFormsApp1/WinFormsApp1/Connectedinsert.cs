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
    public partial class Connectedinsert : Form
    {
        public Connectedinsert()
        {
            InitializeComponent();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Company_SD;Trusted_Connection=true;TrustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            //command.CommandText = $"insert into authors (au_id,au_fname,au_lname,address) values('{txtId.Text}','{txtFName.Text}','{txtLName.Text}','{txtAddress.Text}')";
            command.CommandText = "insert into Employee (ssn,Emp_Fname,Emp_Lname,address) values(@id,@fname,@lname,@address)";

            command.Parameters.AddWithValue("@id", txtID.Text);
            command.Parameters.AddWithValue("@fname", txtFname.Text);
            command.Parameters.AddWithValue("@lname", txtLname.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);

            //REMEBER
            command.Connection = con;

            try
            {
                con.Open();
                label5.Text = $"{command.ExecuteNonQuery()} rows affected";
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }
    }
}
