using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TimerControl
{
    public partial class NumberBox : SelectableTextBox
    {
        public int Digits { get; set; } = 2;
        public string DefaultValue { get; set; } = "00";
        private string numberPattern = @"[0-9]";
        public int Value
        {
            get
            {
                return int.Parse(this.Text);
            }
            set
            {
                if (value < 10)
                {
                    this.Text = "0" + value;
                }
                else
                {
                    this.Text = "" + value;
                }
            }
        }


        public NumberBox()
        {
            InitializeComponent();
            this.AcceptsReturn = false;
            if(Text == "")
            {
                Value = 0;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if ((!Regex.IsMatch(e.KeyChar.ToString(), numberPattern) || Text.Length >= Digits && this.SelectionLength < 1) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool HasTime()
        {
            return this.Value > 0;
        }

        public void Decrement()
        {
            this.Value -= 1;
        }

        public void Reset()
        {
            this.Value = 59;
        }

        private void FormatText()
        {
            if (int.Parse(this.Text) < 10 && this.Text.Length == 1)
            {
                this.Text = "0" + this.Text;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (this.Text == "")
            {
                this.Text = this.DefaultValue;
            }
            else
            {
                FormatText();
            }
        }

    }
}
