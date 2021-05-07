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
        private float age;
        private double MaxHr;
        private double Hr;
        private string stepHeight;

        private float lvl1;
        private float lvl2;
        private float lvl3;
        private float lvl4;
        private float lvl5;

        private float x1;
        private float x2;
        private float x3;
        private float x4;
        private float x5;

        private float m;
        private float Xmean;
        private float Ymean;
        private float b;

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
                    errorString = MessageBox.Show("Please enter a correct value", getYmean().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if ((txtBoxAge.Text == "" | txtBoxName.Text == "" | getStepHeight() == "") | (!radioButtonFemale.Checked & !radioButtonMale.Checked))
            {
                MessageBox.Show("Please fill in all fields", "Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getValueXAxis();
                chartDataStep.Titles.Add("Results of the test");
                chartDataStep.ChartAreas["ChartArea1"].AxisY.Title = @"Heart Rate (b/min)";
                chartDataStep.ChartAreas["ChartArea1"].AxisX.Title = @"Aerobic Capcaity (mls02/kg/min)";

                chartDataStep.Series["Heart Rate"].ChartType = SeriesChartType.Line;
                chartDataStep.Series["Heart Rate"].Color = Color.Aquamarine;
                chartDataStep.Series["Heart Rate"].BorderWidth = 3;
                chartDataStep.Series["Heart Rate"].Points.AddXY(x1, lvl1);
                chartDataStep.Series["Heart Rate"].Points.AddXY(x2, lvl2);
                chartDataStep.Series["Heart Rate"].Points.AddXY(x3, lvl3);
                chartDataStep.Series["Heart Rate"].Points.AddXY(x4, lvl4);
                chartDataStep.Series["Heart Rate"].Points.AddXY(x5, lvl5);
                btnValidate.Enabled = false;
            }
        }

        private void chartDataStep_Click(object sender, EventArgs e)
        {

        }

        private string getStepHeight()
        {
            stepHeight = comboBoxHeight.Text;
            return stepHeight;
        }
        
        private void getXmean()
        {

        }

        private float getYmean()
        {
            Ymean = (lvl1 + lvl2 + lvl3 + lvl4 + lvl5) / 5;
            return Ymean;
        }

        private void getValueXAxis()
        {
            if (getStepHeight() == "15cm")
            {
                x1 = 11;
                x2 = 14;
                x3 = 18;
                x4 = 21;
                x5 = 25;
            }
            else if (getStepHeight() == "20cm")
            {
                x1 = 12;
                x2 = 17;
                x3 = 21;
                x4 = 25;
                x5 = 29;
            }
            else if (getStepHeight() == "25cm")
            {
                x1 = 14;
                x2 = 19;
                x3 = 24;
                x4 = 28;
                x5 = 33;
            }
            else if (getStepHeight()== "30cm")
            {
                x1 = 16;
                x2 = 21;
                x3 = 27;
                x4 = 32;
                x5 = 37;
            }
        }
    }
}
