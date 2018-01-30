namespace TimerControl
{
    partial class TimeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.hmColinLabel = new System.Windows.Forms.Label();
            this.msColinLabel = new System.Windows.Forms.Label();
            this.secondsBox = new TimerControl.NumberBox();
            this.minutesBox = new TimerControl.NumberBox();
            this.hoursBox = new TimerControl.NumberBox();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.Location = new System.Drawing.Point(8, 12);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(46, 17);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(66, 12);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(57, 17);
            this.minutesLabel.TabIndex = 4;
            this.minutesLabel.Text = "Minutes";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(134, 12);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(63, 17);
            this.secondsLabel.TabIndex = 5;
            this.secondsLabel.Text = "Seconds";
            // 
            // hmColinLabel
            // 
            this.hmColinLabel.AutoSize = true;
            this.hmColinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmColinLabel.Location = new System.Drawing.Point(50, 31);
            this.hmColinLabel.Name = "hmColinLabel";
            this.hmColinLabel.Size = new System.Drawing.Size(24, 32);
            this.hmColinLabel.TabIndex = 6;
            this.hmColinLabel.Text = ":";
            // 
            // msColinLabel
            // 
            this.msColinLabel.AutoSize = true;
            this.msColinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msColinLabel.Location = new System.Drawing.Point(117, 31);
            this.msColinLabel.Name = "msColinLabel";
            this.msColinLabel.Size = new System.Drawing.Size(24, 32);
            this.msColinLabel.TabIndex = 7;
            this.msColinLabel.Text = ":";
            // 
            // secondsBox
            // 
            this.secondsBox.Digits = 2;
            this.secondsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsBox.Location = new System.Drawing.Point(143, 28);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(42, 41);
            this.secondsBox.TabIndex = 2;
            this.secondsBox.Text = "00";
            this.secondsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minutesBox
            // 
            this.minutesBox.Digits = 2;
            this.minutesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesBox.Location = new System.Drawing.Point(73, 28);
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(42, 41);
            this.minutesBox.TabIndex = 1;
            this.minutesBox.Text = "00";
            this.minutesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursBox
            // 
            this.hoursBox.Digits = 2;
            this.hoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursBox.Location = new System.Drawing.Point(10, 28);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(42, 41);
            this.hoursBox.TabIndex = 0;
            this.hoursBox.Text = "00";
            this.hoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.minutesBox);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.hmColinLabel);
            this.Controls.Add(this.msColinLabel);
            this.Name = "TimeControl";
            this.Size = new System.Drawing.Size(205, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label hmColinLabel;
        private System.Windows.Forms.Label msColinLabel;
        private TimerControl.NumberBox minutesBox;
        private TimerControl.NumberBox secondsBox;
        private TimerControl.NumberBox hoursBox;
    }
}
