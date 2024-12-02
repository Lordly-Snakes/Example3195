using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3195
{
    public partial class setting : Form
    {
        Form1 form1;

        public setting(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
            numericUpDown1.Value = form1.R1;
            numericUpDown2.Value = form1.R2;
            numericUpDown3.Value = form1.Time;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            changeValues();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            changeValues();
        }


        private void changeValues()
        {

            if (numericUpDown2.Value - numericUpDown1.Value < 100)
            {
                if (numericUpDown2.Value + 1 < numericUpDown2.Maximum)
                {
                    numericUpDown2.Value++;
                }
                else if (numericUpDown1.Value - 1 > 0)
                {
                    numericUpDown1.Value--;
                }
            }
            form1.R1 = (int)numericUpDown1.Value;
            form1.R2 = (int)numericUpDown2.Value;


        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            form1.Time = (int)numericUpDown3.Value;
        }
    }
}
