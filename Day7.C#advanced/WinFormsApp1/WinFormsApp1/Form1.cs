using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            this.BackColor = Color.Aqua;


            InitializeComponent();


        }

        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public string Operator { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // btn1.AppendText("1");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.AppendText("0");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.AppendText("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(textBox1.Text);
            Operator = "-";
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox1.AppendText("8");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Num1 = double.Parse(textBox1.Text);
            Operator = "+";
            textBox1.Clear();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt32(textBox1.Text);
            Operator = "/";
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt32(textBox1.Text);
            Operator = "*";
            textBox1.Clear();
        }

        private void btnEvent(object sender, EventArgs e)
        {
            var obj = sender as Button;
            textBox1.AppendText(obj.Text);


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Num2 = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            switch (Operator)
            {
                case "+":
                    textBox1.Text = (Num1 + Num2).ToString();
                    break;

                case "-":
                    textBox1.Text = (Num1 - Num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (Num1 * Num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (Num1 / Num2).ToString();
                    break;
            }
        }
    }
}