namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTal1 = new Label();
            lblTal2 = new Label();
            txtTal1 = new TextBox();
            txtTal2 = new TextBox();
            txtResultat = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnGanger = new Button();
            btnDela = new Button();
            SuspendLayout();
            //
            // lblTal1
            //
            lblTal1.AutoSize = true;
            lblTal1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTal1.Location = new Point(25, 22);
            lblTal1.Name = "lblTal1";
            lblTal1.Size = new Size(38, 15);
            lblTal1.TabIndex = 0;
            lblTal1.Text = "Tal 1:";
            //
            // lblTal2
            //
            lblTal2.AutoSize = true;
            lblTal2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTal2.Location = new Point(140, 22);
            lblTal2.Name = "lblTal2";
            lblTal2.Size = new Size(38, 15);
            lblTal2.TabIndex = 1;
            lblTal2.Text = "Tal 2:";
            //
            // txtTal1
            //
            txtTal1.Location = new Point(25, 42);
            txtTal1.Name = "txtTal1";
            txtTal1.Size = new Size(90, 23);
            txtTal1.TabIndex = 2;
            //
            // txtTal2
            //
            txtTal2.Location = new Point(140, 42);
            txtTal2.Name = "txtTal2";
            txtTal2.Size = new Size(90, 23);
            txtTal2.TabIndex = 3;
            //
            // txtResultat
            //
            txtResultat.Location = new Point(25, 82);
            txtResultat.Name = "txtResultat";
            txtResultat.ReadOnly = true;
            txtResultat.Size = new Size(205, 23);
            txtResultat.TabIndex = 4;
            txtResultat.TextAlign = HorizontalAlignment.Center;
            //
            // btnPlus
            //
            btnPlus.Font = new Font("Segoe UI", 14F);
            btnPlus.Location = new Point(25, 125);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(90, 55);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            //
            // btnMinus
            //
            btnMinus.Font = new Font("Segoe UI", 14F);
            btnMinus.Location = new Point(140, 125);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(90, 55);
            btnMinus.TabIndex = 6;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            //
            // btnGanger
            //
            btnGanger.Font = new Font("Segoe UI", 14F);
            btnGanger.Location = new Point(25, 195);
            btnGanger.Name = "btnGanger";
            btnGanger.Size = new Size(90, 55);
            btnGanger.TabIndex = 7;
            btnGanger.Text = "*";
            btnGanger.UseVisualStyleBackColor = true;
            btnGanger.Click += btnGanger_Click;
            //
            // btnDela
            //
            btnDela.Font = new Font("Segoe UI", 14F);
            btnDela.Location = new Point(140, 195);
            btnDela.Name = "btnDela";
            btnDela.Size = new Size(90, 55);
            btnDela.TabIndex = 8;
            btnDela.Text = "/";
            btnDela.UseVisualStyleBackColor = true;
            btnDela.Click += btnDela_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 275);
            Controls.Add(btnDela);
            Controls.Add(btnGanger);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtResultat);
            Controls.Add(txtTal2);
            Controls.Add(txtTal1);
            Controls.Add(lblTal2);
            Controls.Add(lblTal1);
            Name = "Form1";
            Text = "Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTal1;
        private Label lblTal2;
        private TextBox txtTal1;
        private TextBox txtTal2;
        private TextBox txtResultat;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnGanger;
        private Button btnDela;
    }
}
