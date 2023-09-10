using Microsoft.Data.SqlClient;
using System.Data;


namespace WinFormsApp1
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();

            FillEmployeeList();
        }
        private void FillEmployeeList()
        {
            SqlConnection con = new SqlConnection("Data source=.;initial catalog=Company_SD;integrated security=true;trustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select SSN, Emp_Fname + ' ' + Emp_Lname as FullName  from dbo.Employee";
            //REMEMBER
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                //  dataGridView1.DataSource = dt;
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

            var ssn = comboBox1.SelectedValue.ToString(); //(sender as ComboBox).SelectedValue 

            SqlConnection con = new SqlConnection("Data source=.;initial catalog=company_SD;integrated security=true;trustServerCertificate=true");
            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT e.Emp_Fname + ' ' + e.Emp_Lname AS EmployeeName, pr.Pname AS ProjectName FROM Employee e INNER JOIN Departments d ON e.Dno = d.Dnum INNER JOIN Project pr\r\nON pr.Dnum = d.Dnum INNER JOIN Works_for w ON e.SSN = w.Essn AND pr.Pnumber = w.Pno ORDER BY EmployeeName, ProjectName";
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }
        }

    }

}

