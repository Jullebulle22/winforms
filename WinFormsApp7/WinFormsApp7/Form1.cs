namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private double forstaTal = 0;
        private string operation = "";
        private bool nyInmatning = true;
        private string dec = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public Form1()
        {
            InitializeComponent();
        }

        private void LaggTillSiffra(string siffra)
        {
            if (nyInmatning) { lblDisplay.Text = "0"; nyInmatning = false; }
            if (lblDisplay.Text == "0") lblDisplay.Text = "";
            lblDisplay.Text += siffra;
        }

        private void LaggTillDecimal()
        {
            if (nyInmatning) { lblDisplay.Text = "0"; nyInmatning = false; }
            if (!lblDisplay.Text.Contains(dec)) lblDisplay.Text += dec;
        }

        private void ValjOperator(string op)
        {
            forstaTal = LasTal();
            operation = op;
            lblHistorik.Text = lblDisplay.Text + " " + op;
            nyInmatning = true;
        }

        private void RaknaUt()
        {
            if (operation == "") return;
            double andraTal = LasTal();
            double svar = 0;

            if (operation == "+") svar = forstaTal + andraTal;
            else if (operation == "-") svar = forstaTal - andraTal;
            else if (operation == "x") svar = forstaTal * andraTal;
            else if (operation == "/")
            {
                if (andraTal == 0)
                {
                    lblHistorik.Text = "";
                    lblDisplay.Text = "Kan inte dela med 0";
                    operation = "";
                    nyInmatning = true;
                    return;
                }
                svar = forstaTal / andraTal;
            }

            lblHistorik.Text = forstaTal + " " + operation + " " + andraTal + " =";
            lblDisplay.Text = svar.ToString();
            operation = "";
            nyInmatning = true;
        }

        private double LasTal()
        {
            double.TryParse(lblDisplay.Text, out double tal);
            return tal;
        }

        private void NollstallAllt()
        {
            lblDisplay.Text = "0";
            lblHistorik.Text = "";
            forstaTal = 0;
            operation = "";
            nyInmatning = true;
        }

        private void NollstallInmatning()
        {
            lblDisplay.Text = "0";
            nyInmatning = true;
        }

        private void RaderaSista()
        {
            if (nyInmatning) return;
            lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            if (lblDisplay.Text == "" || lblDisplay.Text == "-")
            {
                lblDisplay.Text = "0";
                nyInmatning = true;
            }
        }

        private void VaxlaTecken()
        {
            if (lblDisplay.Text.StartsWith("-"))
                lblDisplay.Text = lblDisplay.Text.Substring(1);
            else if (lblDisplay.Text != "0")
                lblDisplay.Text = "-" + lblDisplay.Text;
        }

        private void Siffra_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            LaggTillSiffra(b.Text);
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ValjOperator(b.Text);
        }

        private void btnDot_Click(object sender, EventArgs e) { LaggTillDecimal(); }
        private void btnEquals_Click(object sender, EventArgs e) { RaknaUt(); }
        private void btnCE_Click(object sender, EventArgs e) { NollstallInmatning(); }
        private void btnC_Click(object sender, EventArgs e) { NollstallAllt(); }
        private void btnBack_Click(object sender, EventArgs e) { RaderaSista(); }
        private void btnSign_Click(object sender, EventArgs e) { VaxlaTecken(); }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c >= '0' && c <= '9') LaggTillSiffra(c.ToString());
            else if (c == ',' || c == '.') LaggTillDecimal();
            else if (c == '+') ValjOperator("+");
            else if (c == '-') ValjOperator("-");
            else if (c == '*') ValjOperator("x");
            else if (c == '/') ValjOperator("/");
            else if (c == '\r' || c == '=') RaknaUt();
            else if (c == '\b') RaderaSista();
            else if (c == (char)27) NollstallAllt();
            e.Handled = true;
        }
    }
}
