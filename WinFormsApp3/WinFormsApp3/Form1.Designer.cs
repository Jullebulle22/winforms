namespace WinFormsApp3
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
            lblBanner = new Label();
            pictureBox1 = new PictureBox();
            lblClick = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            //
            // lblBanner
            //
            lblBanner.BackColor = Color.HotPink;
            lblBanner.Dock = DockStyle.Top;
            lblBanner.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblBanner.ForeColor = Color.White;
            lblBanner.Location = new Point(0, 0);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(540, 90);
            lblBanner.TabIndex = 0;
            lblBanner.Text = "OWOWOWO";
            lblBanner.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pictureBox1
            //
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(190, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Bild_Click;
            //
            // lblClick
            //
            lblClick.BackColor = Color.Transparent;
            lblClick.Cursor = Cursors.Hand;
            lblClick.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClick.ForeColor = Color.White;
            lblClick.Location = new Point(40, 35);
            lblClick.Name = "lblClick";
            lblClick.Size = new Size(80, 20);
            lblClick.TabIndex = 0;
            lblClick.Text = "Click me!";
            lblClick.TextAlign = ContentAlignment.MiddleCenter;
            lblClick.Click += Bild_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(540, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblBanner);
            Name = "Form1";
            Text = "Uppgift 3";
            pictureBox1.Controls.Add(lblClick);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBanner;
        private PictureBox pictureBox1;
        private Label lblClick;
    }
}
