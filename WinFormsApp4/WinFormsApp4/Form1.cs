namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        // Raknaren som visas pa skarmen.
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Start/Stop-knappen startar eller stoppar timern.
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        // Timern tickar en gang i sekunden och okar raknaren.
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }
    }
}
