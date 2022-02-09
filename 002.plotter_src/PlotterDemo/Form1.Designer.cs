namespace PlotterDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.StartStopButton = new System.Windows.Forms.Button ();
            this.trackBar1 = new System.Windows.Forms.TrackBar ();
            this.runningGraph1 = new Slepov.WinForms.Plotter ();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit ();
            this.SuspendLayout ();
            // 
            // StartStopButton
            // 
            this.StartStopButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartStopButton.Location = new System.Drawing.Point (12, 253);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size (75, 23);
            this.StartStopButton.TabIndex = 1;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler (this.StartStopButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point (384, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size (37, 235);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            // 
            // runningGraph1
            // 
            this.runningGraph1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.runningGraph1.BackColor = System.Drawing.Color.DarkGreen;
            this.runningGraph1.ForeColor = System.Drawing.Color.Lime;
            this.runningGraph1.Location = new System.Drawing.Point (12, 12);
            this.runningGraph1.Max = 105F;
            this.runningGraph1.Min = -5F;
            this.runningGraph1.Name = "runningGraph1";
            this.runningGraph1.Size = new System.Drawing.Size (366, 235);
            this.runningGraph1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (433, 288);
            this.Controls.Add (this.trackBar1);
            this.Controls.Add (this.StartStopButton);
            this.Controls.Add (this.runningGraph1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Plotter Demo";
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private Slepov.WinForms.Plotter runningGraph1;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

