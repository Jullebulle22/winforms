namespace WinFormsApp4
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
            lblCount = new Label();
            btnStartStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // lblCount
            //
            lblCount.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblCount.Location = new Point(0, 10);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(250, 80);
            lblCount.TabIndex = 0;
            lblCount.Text = "0";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnStartStop
            //
            btnStartStop.Font = new Font("Segoe UI", 12F);
            btnStartStop.Location = new Point(40, 100);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(170, 60);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start/Stop";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            //
            // timer1
            //
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 180);
            Controls.Add(btnStartStop);
            Controls.Add(lblCount);
            Name = "Form1";
            Text = "Time";
            ResumeLayout(false);
        }

        #endregion

        private Label lblCount;
        private Button btnStartStop;
        private System.Windows.Forms.Timer timer1;
    }
}
