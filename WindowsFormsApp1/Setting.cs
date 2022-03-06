using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton1.Checked.Equals(true))
                {
                    Form1.Fam.Enabled = true;
                    Form1.nameText.Enabled = true;
                    Form1.desText.Enabled = true;
                }
                else
                {
                    Form1.famText.Enabled = false;
                    Form1.nameText.Enabled = false;
                    Form1.desText.Enabled = false;
                }
            }
        }
    }
}
