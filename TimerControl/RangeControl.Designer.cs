namespace TimerControl
{
    partial class RangeControl
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
            this.StartBox = new TimerControl.NumberBox();
            this.EndBox = new TimerControl.NumberBox();
            this.SuspendLayout();
            // 
            // StartBox
            // 
            this.StartBox.Digits = 5;
            this.StartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBox.Location = new System.Drawing.Point(85, 15);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(95, 38);
            this.StartBox.TabIndex = 0;
            this.StartBox.Text = "1000";
            this.StartBox.TextChanged += new System.EventHandler(this.numberBox1_TextChanged);
            // 
            // EndBox
            // 
            this.EndBox.Digits = 5;
            this.EndBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndBox.Location = new System.Drawing.Point(85, 59);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(95, 38);
            this.EndBox.TabIndex = 1;
            this.EndBox.Text = "2000";
            // 
            // RangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.EndBox);
            this.Name = "RangeControl";
            this.Size = new System.Drawing.Size(196, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberBox StartBox;
        private NumberBox EndBox;
    }
}
