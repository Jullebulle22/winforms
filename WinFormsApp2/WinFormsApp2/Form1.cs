namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VisaStorsta()
        {
            bool ok1 = int.TryParse(textBox1.Text, out int tal1);
            bool ok2 = int.TryParse(textBox2.Text, out int tal2);

            if (ok1 && ok2)
            {
                if (tal1 > tal2)
                {
                    textBox3.Text = tal1.ToString();
                }
                else
                {
                    textBox3.Text = tal2.ToString();
                }
            }
            else
            {
                textBox3.Text = "Skriv heltal!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VisaStorsta();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            VisaStorsta();
        }
    }
}
