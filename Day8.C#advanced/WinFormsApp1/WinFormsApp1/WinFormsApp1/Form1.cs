using System.Data;
using Microsoft.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillEmployeesList();

        }

        private void FillEmployeesList()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-ENI7P6D;Database=Company_SD;trusted_connection=true;trustServerCertificate=true")
            {

            };
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from employee";
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                gridEmployee.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }

        }

        private void gridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//Company Employee      ITI Student


//form to display All Employees
//form to choose employee and returns his/her projets
//form to insert employee
//form to update/delete Employee
