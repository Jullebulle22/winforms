namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        // Anvands for att slumpa fram farger.
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Disco-knappen startar eller stoppar timern (Start/Stop).
        private void btnDisco_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        // Varje gang timern tickar far formen en ny slumpad bakgrundsfarg.
        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}
