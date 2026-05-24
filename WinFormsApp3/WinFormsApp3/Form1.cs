namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = SkapaSolBild();
        }

        private Bitmap SkapaSolBild()
        {
            Bitmap bild = new Bitmap(160, 90);
            using (Graphics g = Graphics.FromImage(bild))
            {
                g.Clear(Color.Black);
                g.FillEllipse(Brushes.OrangeRed, 45, 10, 70, 70);
                g.FillEllipse(Brushes.Gold, 60, 25, 40, 40);
            }
            return bild;
        }

        private void Bild_Click(object sender, EventArgs e)
        {
            Form2 andraFormen = new Form2();
            andraFormen.Show();
        }
    }
}
