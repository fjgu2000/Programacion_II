namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            Form2 ja=new Form2();
            if(txtusu.Text=="Javier")
            {
                if(txtcon.Text=="1234")
                {
                    ja.Show();
                    ja.txt2.Visible = true;
                    ja.btn2.Visible= true;
                    ja.btn3.Visible= true;
                }
            }
            else
            {
                if(txtusu.Text=="Carlos")
                {
                    if(txtcon.Text=="9876")
                    {
                        ja.Show();
                    }
                }
            }
        }
    }
}