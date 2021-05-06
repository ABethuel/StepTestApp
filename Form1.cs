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
            
            try
            {
                float age = (float)double.Parse(txtBoxAge.Text);
                double variable = Convert.ToDouble(age);
                double MaxHr = age + 220;
                double Hr = MaxHr * 0.85;
                lblMaxHR.Text = MaxHr.ToString();
                lblHR.Text = Hr.ToString();
                lblB1.Text = "b/min";
                lblB2.Text = "b/min";
            }
            catch
            {
                DialogResult errorString;
                errorString = MessageBox.Show("Please enter correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMaxHR.Text = "/";
                lblHR.Text = "/";
            }

            /*if (txtBoxAge.Text == "")
            {
                lblMaxHR.Text = "/";
                lblHR.Text = "/";
            }
            else 
            {
                float age = (float)double.Parse(txtBoxAge.Text);
                double MaxHr = age + 220;
                double Hr = MaxHr * 0.85;
                lblMaxHR.Text = MaxHr.ToString();
                lblHR.Text = Hr.ToString();
                lblB1.Text = "b/min";
                lblB2.Text = "b/min";
            }*/
        }

        private void lblMaxHR_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
