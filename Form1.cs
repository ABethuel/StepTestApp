using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StepTestApp
{
    public partial class Form1 : Form
    {
        float age;
        double MaxHr;
        double Hr;
        float lvl1;
        float lvl2;
        float lvl3;
        float lvl4;
        float lvl5;

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
                age = (float)double.Parse(txtBoxAge.Text);
                MaxHr = age + 220;
                Hr = MaxHr * 0.85;
                lblMaxHR.Text = MaxHr.ToString();
                lblHR.Text = Hr.ToString();
                lblB1.Text = "b/min";
                lblB2.Text = "b/min";
            }
            catch
            {
                if (txtBoxAge.Text == "")
                {
                    lblMaxHR.Text = "/";
                    lblHR.Text = "/";
                }
                else
                {
                    DialogResult errorString;
                    errorString = MessageBox.Show("Please enter a correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblMaxHR.Text = "/";
                    lblHR.Text = "/";
                    txtBoxAge.Text = "";
                }       
            }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxLvl1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lvl1 = (float)double.Parse(txtBoxLvl1.Text);
            }
            catch
            {
                if (txtBoxLvl1.Text == "")
                {
                    txtBoxLvl1.Text = "";
                }
                else
                {
                    DialogResult errorString;
                    errorString = MessageBox.Show("Please enter a correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxLvl1.Text = "";
                }
            }
        }

        private void txtBoxLvl2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lvl2 = (float)double.Parse(txtBoxLvl2.Text);
            }
            catch
            {
                if (txtBoxLvl2.Text == "")
                {
                    txtBoxLvl2.Text = "";
                }
                else
                {
                    DialogResult errorString;
                    errorString = MessageBox.Show("Please enter a correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxLvl2.Text = "";
                }
            }
        }

        private void txtBoxLvl3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lvl3 = (float)double.Parse(txtBoxLvl3.Text);
            }
            catch
            {
                if (txtBoxLvl3.Text == "")
                {
                    txtBoxLvl1.Text = "";
                }
                else
                {
                    DialogResult errorString;
                    errorString = MessageBox.Show("Please enter a correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxLvl3.Text = "";
                }
            }
        }

        private void txtBoxLvl4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lvl4 = (float)double.Parse(txtBoxLvl4.Text);
            }
            catch
            {
                if (txtBoxLvl4.Text == "")
                {
                    txtBoxLvl4.Text = "";
                }
                else
                {
                    DialogResult errorString;
                    errorString = MessageBox.Show("Please enter a correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxLvl4.Text = "";
                }
            }
        }

        private void txtBoxLvl5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lvl5 = (float)double.Parse(txtBoxLvl5.Text);
            }
            catch
            {
                if (txtBoxLvl5.Text == "")
                {
                    txtBoxLvl5.Text = "";
                }
                else
                {
                    DialogResult errorString;
                    errorString = MessageBox.Show("Please enter a correct value", "Warning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxLvl5.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtBoxAge.Text == "" | txtBoxName.Text == "" | comboBoxHeight.Text== "") | (!radioButtonFemale.Checked & !radioButtonMale.Checked))
            {
                MessageBox.Show("Please fill in all fields", "Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chartDataStep.Series["Heart Rate"].ChartType = SeriesChartType.Line;
                chartDataStep.Series["Heart Rate"].Color = Color.Aquamarine;
                chartDataStep.Series["Heart Rate"].BorderWidth = 3;
                chartDataStep.Series["Heart Rate1"].Points.AddXY(20, lvl1);
                chartDataStep.Series["Heart Rate"].Points.AddXY(30, lvl2);
                chartDataStep.Series["Heart Rate"].Points.AddXY(50, lvl3);
                chartDataStep.Series["Heart Rate"].Points.AddXY(60, lvl4);
                chartDataStep.Series["Heart Rate"].Points.AddXY(70, lvl5);
            }
        }

        private void chartDataStep_Click(object sender, EventArgs e)
        {

        }
    }
}
