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
    public partial class VariableTimeBox : UserControl
    {
        private string previousUom;
        private string selectedUom;
        public VariableTimeBox()
        {
            InitializeComponent();
            SetComboBoxValues();
            previousUom = (string)comboBox.SelectedItem;
        }

        public void SetComboBoxValues()
        {
            comboBox.Items.Add("ms");
            comboBox.Items.Add("s");
            comboBox.Items.Add("m");
            comboBox.SelectedItem = comboBox.Items[0];
        }

        private bool UomsAreDifferent()
        {
            return !(selectedUom == previousUom);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUom = (string)comboBox.SelectedItem;
            if (!(selectedUom == previousUom)) {
                switch (selectedUom)
                {
                    case "ms":
                        break;
                    case "s":
                        break;
                    case "m":
                        break;
                }
            }

        }
    }
}
