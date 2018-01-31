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
        public bool FormatCommas { get; set; }
        public int DefaultValue { get; set; }
        private string numberPattern = @"[0-9]";
        public int Value
        {
            get
            {
                return int.Parse(this.Text.Replace(",", ""));
            }
            set
            {
                this.Text = FormatText(""+value);
            }
        }


        public NumberBox()
        {
            InitializeComponent();
            this.AcceptsReturn = false;
            this.ShortcutsEnabled = false;
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
            Text = FormatText(Text);
        }

        private string FormatText(string text)
        {
            int value = (Text.Length > 0) ? int.Parse(text.Replace(",", "")) : 0;
            string valueBase = (value < 10) ? "0" : "";
            return valueBase + value.ToString("N0");
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            FormatText();
        }

    }
}
