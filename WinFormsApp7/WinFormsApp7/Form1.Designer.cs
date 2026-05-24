namespace WinFormsApp7
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
            lblHistorik = new Label();
            lblDisplay = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnBack = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btnSign = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            SuspendLayout();
            //
            // lblHistorik
            //
            lblHistorik.ForeColor = Color.Gray;
            lblHistorik.Location = new Point(8, 6);
            lblHistorik.Name = "lblHistorik";
            lblHistorik.Size = new Size(230, 18);
            lblHistorik.TabIndex = 0;
            lblHistorik.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblDisplay
            //
            lblDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblDisplay.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDisplay.Location = new Point(8, 26);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(230, 46);
            lblDisplay.TabIndex = 1;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnCE
            //
            btnCE.Location = new Point(10, 80);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(52, 42);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            //
            // btnC
            //
            btnC.Location = new Point(68, 80);
            btnC.Name = "btnC";
            btnC.Size = new Size(52, 42);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            //
            // btnBack
            //
            btnBack.Location = new Point(126, 80);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(52, 42);
            btnBack.TabIndex = 4;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // btnDiv
            //
            btnDiv.Font = new Font("Segoe UI", 12F);
            btnDiv.Location = new Point(184, 80);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(52, 42);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += Operator_Click;
            //
            // btn7
            //
            btn7.Font = new Font("Segoe UI", 12F);
            btn7.Location = new Point(10, 128);
            btn7.Name = "btn7";
            btn7.Size = new Size(52, 42);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Siffra_Click;
            //
            // btn8
            //
            btn8.Font = new Font("Segoe UI", 12F);
            btn8.Location = new Point(68, 128);
            btn8.Name = "btn8";
            btn8.Size = new Size(52, 42);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Siffra_Click;
            //
            // btn9
            //
            btn9.Font = new Font("Segoe UI", 12F);
            btn9.Location = new Point(126, 128);
            btn9.Name = "btn9";
            btn9.Size = new Size(52, 42);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Siffra_Click;
            //
            // btnMul
            //
            btnMul.Font = new Font("Segoe UI", 12F);
            btnMul.Location = new Point(184, 128);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(52, 42);
            btnMul.TabIndex = 9;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += Operator_Click;
            //
            // btn4
            //
            btn4.Font = new Font("Segoe UI", 12F);
            btn4.Location = new Point(10, 176);
            btn4.Name = "btn4";
            btn4.Size = new Size(52, 42);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Siffra_Click;
            //
            // btn5
            //
            btn5.Font = new Font("Segoe UI", 12F);
            btn5.Location = new Point(68, 176);
            btn5.Name = "btn5";
            btn5.Size = new Size(52, 42);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Siffra_Click;
            //
            // btn6
            //
            btn6.Font = new Font("Segoe UI", 12F);
            btn6.Location = new Point(126, 176);
            btn6.Name = "btn6";
            btn6.Size = new Size(52, 42);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Siffra_Click;
            //
            // btnSub
            //
            btnSub.Font = new Font("Segoe UI", 12F);
            btnSub.Location = new Point(184, 176);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(52, 42);
            btnSub.TabIndex = 13;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Operator_Click;
            //
            // btn1
            //
            btn1.Font = new Font("Segoe UI", 12F);
            btn1.Location = new Point(10, 224);
            btn1.Name = "btn1";
            btn1.Size = new Size(52, 42);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Siffra_Click;
            //
            // btn2
            //
            btn2.Font = new Font("Segoe UI", 12F);
            btn2.Location = new Point(68, 224);
            btn2.Name = "btn2";
            btn2.Size = new Size(52, 42);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Siffra_Click;
            //
            // btn3
            //
            btn3.Font = new Font("Segoe UI", 12F);
            btn3.Location = new Point(126, 224);
            btn3.Name = "btn3";
            btn3.Size = new Size(52, 42);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Siffra_Click;
            //
            // btnAdd
            //
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(184, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 42);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operator_Click;
            //
            // btnSign
            //
            btnSign.Font = new Font("Segoe UI", 12F);
            btnSign.Location = new Point(10, 272);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(52, 42);
            btnSign.TabIndex = 18;
            btnSign.Text = "-/+";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            //
            // btn0
            //
            btn0.Font = new Font("Segoe UI", 12F);
            btn0.Location = new Point(68, 272);
            btn0.Name = "btn0";
            btn0.Size = new Size(52, 42);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Siffra_Click;
            //
            // btnDot
            //
            btnDot.Font = new Font("Segoe UI", 12F);
            btnDot.Location = new Point(126, 272);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(52, 42);
            btnDot.TabIndex = 20;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            //
            // btnEquals
            //
            btnEquals.Font = new Font("Segoe UI", 12F);
            btnEquals.Location = new Point(184, 272);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(52, 42);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 324);
            Controls.Add(btnEquals);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnSign);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMul);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnBack);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblDisplay);
            Controls.Add(lblHistorik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "My Calculator";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
        }

        #endregion

        private Label lblHistorik;
        private Label lblDisplay;
        private Button btnCE;
        private Button btnC;
        private Button btnBack;
        private Button btnDiv;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btnSign;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;
    }
}
