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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBox
            // 
            this.StartBox.DefaultValue = 0;
            this.StartBox.Digits = 5;
            this.StartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBox.FormatCommas = true;
            this.StartBox.Location = new System.Drawing.Point(3, 3);
            this.StartBox.Name = "StartBox";
            this.StartBox.ShortcutsEnabled = false;
            this.StartBox.Size = new System.Drawing.Size(95, 38);
            this.StartBox.TabIndex = 0;
            this.StartBox.Text = "1,000";
            this.StartBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StartBox.Value = 1000;
            this.StartBox.TextChanged += new System.EventHandler(this.numberBox1_TextChanged);
            // 
            // EndBox
            // 
            this.EndBox.DefaultValue = 0;
            this.EndBox.Digits = 5;
            this.EndBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndBox.FormatCommas = false;
            this.EndBox.Location = new System.Drawing.Point(3, 44);
            this.EndBox.Name = "EndBox";
            this.EndBox.ShortcutsEnabled = false;
            this.EndBox.Size = new System.Drawing.Size(95, 38);
            this.EndBox.TabIndex = 1;
            this.EndBox.Text = "2,000";
            this.EndBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EndBox.Value = 2000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // RangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.EndBox);
            this.Name = "RangeControl";
            this.Size = new System.Drawing.Size(150, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberBox StartBox;
        private NumberBox EndBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
