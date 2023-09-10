using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillEmployeeList();
        }
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

}