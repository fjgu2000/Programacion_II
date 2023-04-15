namespace Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            int num1, num2, res, total = 0;
            num1 = int.Parse(txtnum1.Text);
            num2 = int.Parse(txtnum2.Text);
            if (optsum.Checked==true)
            {
                lbres.Text = Convert.ToString(Suma(num1, num2));
            }
            else if(optres.Checked == true)
            {
                lbres.Text = Convert.ToString(Resta(num1, num2));
            }
            else if (optmul.Checked == true)
            {
                lbres.Text = Convert.ToString(Multi(num1, num2));
            }
            else if (optdiv.Checked == true)
            {
                lbres.Text = Convert.ToString(Divis(num1, num2));
            }
            else
            {
                MessageBox.Show("No se encuentra en la lista");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static int Suma(int num1, int num2)
        {
            return (num1 + num2);
        }
        static int Resta(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int Multi(int num1, int num2)
        {
            return (num1 * num2);
        }
        static int Divis(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir por 0");
                return 0;
            }
            else
            {
                return (num1 / num2);
            }
        }
    }
}