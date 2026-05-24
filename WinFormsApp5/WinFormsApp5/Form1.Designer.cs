namespace WinFormsApp5
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
            components = new System.ComponentModel.Container();
            btnDisco = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // btnDisco
            //
            btnDisco.Font = new Font("Segoe UI", 12F);
            btnDisco.Location = new Point(160, 130);
            btnDisco.Name = "btnDisco";
            btnDisco.Size = new Size(140, 90);
            btnDisco.TabIndex = 0;
            btnDisco.Text = "Disco";
            btnDisco.UseVisualStyleBackColor = true;
            btnDisco.Click += btnDisco_Click;
            //
            // timer1
            //
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 350);
            Controls.Add(btnDisco);
            Name = "Form1";
            Text = "Disco";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisco;
        private System.Windows.Forms.Timer timer1;
    }
}
