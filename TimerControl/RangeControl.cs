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
        public int Start { get { return StartBox.Value; } }
        public int End { get { return EndBox.Value; } }

        public RangeControl()
        {
            InitializeComponent();
        }

        private void numberBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
