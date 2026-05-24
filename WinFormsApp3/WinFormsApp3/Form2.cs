namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        private double vinkel = 0;
        private Color[] farger = { Color.Red, Color.Orange, Color.Yellow, Color.Lime,
                                   Color.Cyan, Color.Blue, Color.Magenta };

        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vinkel += 0.15;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int mittX = pictureBox1.Width / 2;
            int mittY = pictureBox1.Height / 2;

            for (int i = 0; i < 20; i++)
            {
                double a = vinkel + i * 0.6;
                int radie = 20 + i * 6;
                int x = mittX + (int)(radie * Math.Cos(a));
                int y = mittY + (int)(radie * Math.Sin(a));

                using (SolidBrush pensel = new SolidBrush(farger[i % farger.Length]))
                {
                    e.Graphics.FillEllipse(pensel, x - 10, y - 10, 20, 20);
                }
            }
        }
    }
}
