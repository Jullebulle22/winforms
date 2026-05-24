namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Raknar ut svaret beroende pa vilket raknetecken som valts.
        private void Berakna(char tecken)
        {
            bool ok1 = double.TryParse(txtTal1.Text, out double tal1);
            bool ok2 = double.TryParse(txtTal2.Text, out double tal2);

            // Felhantering: om nagot tal inte gar att lasa visar vi ett meddelande.
            if (!ok1 || !ok2)
            {
                txtResultat.Text = "Skriv två tal!";   // tva = tv[a-ring]
                return;
            }

            double svar = 0;
            if (tecken == '+') svar = tal1 + tal2;
            else if (tecken == '-') svar = tal1 - tal2;
            else if (tecken == '*') svar = tal1 * tal2;
            else if (tecken == '/')
            {
                if (tal2 == 0)
                {
                    txtResultat.Text = "Kan inte dela med 0";
                    return;
                }
                svar = tal1 / tal2;
            }

            // Visar hela uttrycket, t.ex. 12-4=8
            txtResultat.Text = tal1 + tecken.ToString() + tal2 + "=" + svar;
        }

        private void btnPlus_Click(object sender, EventArgs e) { Berakna('+'); }
        private void btnMinus_Click(object sender, EventArgs e) { Berakna('-'); }
        private void btnGanger_Click(object sender, EventArgs e) { Berakna('*'); }
        private void btnDela_Click(object sender, EventArgs e) { Berakna('/'); }
    }
}
