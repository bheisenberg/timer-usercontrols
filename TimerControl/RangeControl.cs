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
    public partial class RangeControl : UserControl
    {
        public int Start { get { return StartBox.Value; } set { StartBox.Value = value; } }
        public int End { get { return EndBox.Value; } set { EndBox.Value = value; } }

        public RangeControl()
        {
            InitializeComponent();
        }

        public void Enable()
        {
            this.StartBox.Enabled = true;
            this.EndBox.Enabled = true;
        }

        public void Disable()
        {
            this.StartBox.Enabled = false;
            this.EndBox.Enabled = false;
        }


        public bool IsValid()
        {
            return Start > End;
        }

        private void numberBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
