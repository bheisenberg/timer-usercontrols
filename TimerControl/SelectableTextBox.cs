using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerControl
{
    public partial class SelectableTextBox : TextBox
    {
        public SelectableTextBox()
        {
            InitializeComponent();
        }
        private bool focused;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                this.Enabled = false;
                this.Enabled = true;
                Console.WriteLine("HAY");
                if (focused)
                {
                    this.DeselectAll();
                    focused = false;
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (MouseButtons == MouseButtons.None)
            {
                SelectAll();
                focused = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            focused = false;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (!focused)
            {
                if (SelectionLength == 0)
                {
                    SelectAll();
                }
                focused = true;
            }
        }
    }
}
