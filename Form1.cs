using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            float age = (float)double.Parse(txtBoxAge.Text);
            float MaxHr = age + 220;
            lblMaxHR.Text = MaxHr.ToString();
        }

        private void lblMaxHR_Click(object sender, EventArgs e)
        {

        }
    }
}
