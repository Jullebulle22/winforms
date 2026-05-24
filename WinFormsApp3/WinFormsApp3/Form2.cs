namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        // Vinkeln andras hela tiden sa att cirklarna ror sig runt.
        private double vinkel = 0;

        // Fargerna som cirklarna far (de upprepas).
        private Color[] farger = { Color.Red, Color.Orange, Color.Yellow, Color.Lime,
                                   Color.Cyan, Color.Blue, Color.Magenta };

        public Form2()
        {
            InitializeComponent();
            timer1.Start();   // starta animeringen direkt nar fonstret oppnas
        }

        // Timern tickar manga ganger per sekund och ber om en ny omritning.
        private void timer1_Tick(object sender, EventArgs e)
        {
            vinkel += 0.15;
            pictureBox1.Invalidate();   // gor att Paint nedan kors igen
        }

        // Ritar cirklarna. Kors varje gang rutan ritas om.
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int mittX = pictureBox1.Width / 2;
            int mittY = pictureBox1.Height / 2;

            for (int i = 0; i < 20; i++)
            {
                double a = vinkel + i * 0.6;   // varje cirkel ligger lite langre fram i ringen
                int radie = 20 + i * 6;        // och lite langre ut (ger en spiral)
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
