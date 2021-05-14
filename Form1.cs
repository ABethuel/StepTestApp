﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StepTestApp
{
    public partial class Form1 : Form
    {
        private string name;
        private float age;
        private double MaxHr;
        private double Hr;
        private string stepHeight;
        private string date;
        private string gender;

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
        private float XmultY;
        private float Xsquared;

        private List<float> ListValues = new List<float>();
        private List<float> ListXaxis = new List<float>();

        private float aerobic_capacity;
        private string rating;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                MaxHr = 220 - age;
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
                    errorString = MessageBox.Show("Please enter a correct value", "Error String", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DbEntities db = new DbEntities();
            List<StepTest> listTest = db.StepTests.ToList();

            foreach (StepTest item in listTest)
            {
                comboBoxName.Items.Add(item.Name);
            }


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
                    txtBoxLvl3.Text = "";
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
            getValueXAxis();
            getValuesList();

            if ((txtBoxAge.Text == "" | comboBoxName.Text == "" | getStepHeight() == "" | txtBoxLvl1.Text == "" | txtBoxLvl2.Text == "" | 
                txtBoxLvl3.Text == "" | txtBoxLvl4.Text == "" | txtBoxLvl5.Text == "") | 
                (!radioButtonFemale.Checked & !radioButtonMale.Checked))
            {
                MessageBox.Show("Please fill in all fields", "Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ListValues.Clear();
                ListXaxis.Clear();
            }
            else
            {
                chartDataStep.Titles.Add("Results of the test");
                chartDataStep.ChartAreas["ChartArea1"].AxisY.Title = @"Heart Rate (b/min)";
                chartDataStep.ChartAreas["ChartArea1"].AxisX.Title = @"Aerobic Capacity (mls02/kg/min)";

                chartDataStep.Series["Heart Rate"].ChartType = SeriesChartType.Line;
                chartDataStep.Series["Heart Rate"].Color = Color.DarkBlue;
                chartDataStep.Series["Heart Rate"].BorderWidth = 3;

                if (getM() < 0)
                {
                    MessageBox.Show("Your Aerobic capacity is negative, there might be an error in the data you entered", "Error Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxLvl1.Text = "";
                    txtBoxLvl2.Text = "";
                    txtBoxLvl3.Text = "";
                    txtBoxLvl4.Text = "";
                    txtBoxLvl5.Text = "";

                    ListValues.Clear();
                    ListXaxis.Clear();
                }
                else {
                    for (int i = 0; i < ListValues.Count; i++)
                    {
                        chartDataStep.Series["Heart Rate"].Points.AddXY(ListXaxis[i], ListValues[i]);
                    }

                    chartDataStep.Series["Average"].ChartType = SeriesChartType.Line;
                    chartDataStep.Series["Average"].Color = Color.Red;
                    chartDataStep.Series["Average"].BorderWidth = 3;
                    chartDataStep.Series["Average"].Points.AddXY(0, getOrdinateOrigin());
                    chartDataStep.Series["Average"].Points.AddXY(getAerobicCapacity(), MaxHr);

                    chartDataStep.Series["Aerobic Capacity"].ChartType = SeriesChartType.Line;
                    chartDataStep.Series["Aerobic Capacity"].Color = Color.Red;
                    chartDataStep.Series["Aerobic Capacity"].BorderWidth = 3;
                    chartDataStep.Series["Aerobic Capacity"].Points.AddXY(getAerobicCapacity(), 0);
                    chartDataStep.Series["Aerobic Capacity"].Points.AddXY(getAerobicCapacity(), MaxHr);

                    btnValidate.Enabled = false;
                    btnSave.Visible = true;

                    lblAerobicCapacity.Text = "Aerobic capacity :   " + getAerobicCapacity().ToString() + "  mls02/kg/min";
                    getRating();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getGender();

            DbEntities db = new DbEntities();
            StepTest stepTest = new StepTest();

            stepTest.Name = getName();
            stepTest.Age = age;
            stepTest.Gender = gender;
            stepTest.Step_Height = getStepHeight();
            stepTest.Aerobic_Capacity = aerobic_capacity;
            stepTest.Rating = rating;
            stepTest.Date = getDate();

            db.StepTests.Add(stepTest);
            db.SaveChanges();

            chartDataStep.Series["Heart Rate"].Points.Clear();
            chartDataStep.Series["Average"].Points.Clear();
            chartDataStep.Series["Aerobic Capacity"].Points.Clear();

            txtBoxLvl1.Text = "";
            txtBoxLvl2.Text = "";
            txtBoxLvl3.Text = "";
            txtBoxLvl4.Text = "";
            txtBoxLvl5.Text = "";

            lblAerobicCapacity.Text = "";
            lblRating.Text = "";

            ListValues.Clear();
            ListXaxis.Clear();

            btnValidate.Enabled = true;
            btnSave.Visible = false;
        }

        private void consultDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }


        private void howToUseTheAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHelp = new FormHelp();
            formHelp.Show();
        }


        private void aboutTheAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout = new FormAbout();
            formAbout.Show();
        }

        private void chartDataStep_Click(object sender, EventArgs e)
        {

        }

        private void lblAerobicCapacity_Click(object sender, EventArgs e)
        {

        }

        private string getName()
        {
            name = comboBoxName.Text;
            return name;
        }

        private string getStepHeight()
        {
            stepHeight = comboBoxHeight.Text;
            return stepHeight;
        }

        private string getDate()
        {
            date = dateTimePicker1.Value.ToString();
            return date;
        }

        private void getGender()
        {
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
        }

        private float getXmean()
        {
            var sumX = ListXaxis.Sum(x => x);
            Xmean = sumX / ListXaxis.Count;
            return Xmean;
        }

        private float getYmean()
        {
            var sumHr = ListValues.Sum(x => x);
            Ymean = (float)(sumHr / ListValues.Count);
            return Ymean;
        }

        private float getXmultipliateY()
        {
            XmultY = 0;
            for (int i = 0; i < ListValues.Count; i++)
            {
                float mult = ListValues[i] * ListXaxis[i];
                XmultY += mult;
            }
            return XmultY;
        }

        private float getSumXsqaured()
        {
            Xsquared = (float)ListXaxis.Sum(x => Math.Pow(x, 2));
            return Xsquared;
        }

        private float getM()
        {
            m = (float)((getXmultipliateY() - (ListValues.Sum(x => x) * ListXaxis.Sum(x => x) / ListValues.Count)) / (getSumXsqaured() - (Math.Pow(ListXaxis.Sum(x => x), 2) / ListValues.Count)));
            return m;
        }

        private float getOrdinateOrigin()
        {
            float origin = getYmean() - getM() * getXmean();
            return origin;
        }

        private float getAerobicCapacity()
        {
            aerobic_capacity = (float)((MaxHr - getOrdinateOrigin()) / getM());
            return aerobic_capacity;
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
            else if (getStepHeight() == "30cm")
            {
                x1 = 16;
                x2 = 21;
                x3 = 27;
                x4 = 32;
                x5 = 37;
            }
            else
            {
                MessageBox.Show("Please enter a correct step height", "Incorrect step height", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxHeight.Text = " ";
            }
        }

        private void getValuesList()
        {
            if (lvl1 >= 0.50 * MaxHr & lvl1 <= 0.85 * MaxHr)
            {
                ListValues.Add(lvl1);
                ListXaxis.Add(x1);
                txtBoxLvl1.ForeColor = Color.Green;
            }
            else if (lvl1 < 0.50 * MaxHr)
            {
                txtBoxLvl1.ForeColor = Color.Red;
            }
            else
            {
                txtBoxLvl1.ForeColor = Color.Blue;
            }

            if (lvl2 >= 0.50 * MaxHr & lvl2 <= 0.85 * MaxHr)
            {
                ListValues.Add(lvl2);
                ListXaxis.Add(x2);
                txtBoxLvl2.ForeColor = Color.Green;
            }
            else if (lvl2 < 0.50 * MaxHr)
            {
                txtBoxLvl2.ForeColor = Color.Red;
            }
            else
            {
                txtBoxLvl2.ForeColor = Color.Blue;
            }

            if (lvl3 >= 0.50 * MaxHr & lvl3 <= 0.85 * MaxHr)
            {
                ListValues.Add(lvl3);
                ListXaxis.Add(x3);
                txtBoxLvl3.ForeColor = Color.Green;
            }
            else if (lvl3 < 0.50 * MaxHr)
            {
                txtBoxLvl3.ForeColor = Color.Red;
            }
            else
            {
                txtBoxLvl3.ForeColor = Color.Blue;
            }

            if (lvl4 >= 0.50 * MaxHr & lvl4 <= 0.85 * MaxHr)
            {
                ListValues.Add(lvl4);
                ListXaxis.Add(x4);
                txtBoxLvl4.ForeColor = Color.Green;
            }
            else if (lvl4 < 0.50 * MaxHr)
            {
                txtBoxLvl4.ForeColor = Color.Red;
            }
            else
            {
                txtBoxLvl4.ForeColor = Color.Blue;
            }

            if (lvl5 >= 0.50 * MaxHr & lvl5 <= 0.85 * MaxHr)
            {
                ListValues.Add(lvl5);
                ListXaxis.Add(x5);
                txtBoxLvl5.ForeColor = Color.Green;
            }
            else if (lvl5 < 0.50 * MaxHr)
            {
                txtBoxLvl5.ForeColor = Color.Red;
            }
            else
            {
                txtBoxLvl5.ForeColor = Color.Blue;
            }
        }

        private void getRating()
        {
            if (radioButtonMale.Checked)
            {
                if (age >= 15 & age <= 19)
                {
                    if (aerobic_capacity >= 60)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 48 & aerobic_capacity < 60)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 39 & aerobic_capacity < 48)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 30 & aerobic_capacity < 39)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 30)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 20 & age <= 29)
                {
                    if (aerobic_capacity >= 55)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 44 & aerobic_capacity < 50)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 35 & aerobic_capacity < 44)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 28 & aerobic_capacity < 35)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 28)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 30 & age <= 39)
                {
                    if (aerobic_capacity >= 50)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 40 & aerobic_capacity < 50)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 34 & aerobic_capacity < 40)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 26 & aerobic_capacity < 34)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 26)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 40 & age <= 49)
                {
                    if (aerobic_capacity >= 46)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 37 & aerobic_capacity < 46)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 32 & aerobic_capacity < 37)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 25 & aerobic_capacity < 32)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 25)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 50 & age <= 59)
                {
                    if (aerobic_capacity >= 44)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 35 & aerobic_capacity < 44)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 29 & aerobic_capacity < 35)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 23 & aerobic_capacity < 29)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 23)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 60 & age <= 65)
                {
                    if (aerobic_capacity >= 40)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 33 & aerobic_capacity < 40)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 25 & aerobic_capacity < 33)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 20 & aerobic_capacity < 25)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 20)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else
                {
                    rating = "/";
                    lblRating.Text = "Fitness Rating :  " + rating;
                }
            }

            if (radioButtonFemale.Checked)
            {
                if (age >= 15 & age <= 19)
                {
                    if (aerobic_capacity >= 55)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 44 & aerobic_capacity < 55)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 36 & aerobic_capacity < 44)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 29 & aerobic_capacity < 36)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 29)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 20 & age <= 29)
                {
                    if (aerobic_capacity >= 50)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 40 & aerobic_capacity < 50)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 32 & aerobic_capacity < 40)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 27 & aerobic_capacity < 32)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 27)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 30 & age <= 39)
                {
                    if (aerobic_capacity >= 46)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 36 & aerobic_capacity <= 45)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 30 & aerobic_capacity <= 35)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 25 & aerobic_capacity <= 29)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 25)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 40 & age <= 49)
                {
                    if (aerobic_capacity >= 43)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 34 & aerobic_capacity <= 42)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 25 & aerobic_capacity <= 33)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 22 & aerobic_capacity <= 27)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 22)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 50 & age <= 59)
                {
                    if (aerobic_capacity >= 41)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 33 & aerobic_capacity <= 40)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 26 & aerobic_capacity <= 32)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 21 & aerobic_capacity <= 25)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 21)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else if (age >= 60 & age <= 65)
                {
                    if (aerobic_capacity >= 39)
                    {
                        rating = "Excellent";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 31 & aerobic_capacity <= 38)
                    {
                        rating = "Good";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 24 & aerobic_capacity <= 30)
                    {
                        rating = "Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity >= 19 & aerobic_capacity <= 23)
                    {
                        rating = "Below Average";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                    else if (aerobic_capacity < 19)
                    {
                        rating = "Poor";
                        lblRating.Text = "Fitness Rating :  " + rating;
                    }
                }

                else
                {
                    rating = "/";
                    lblRating.Text = "Fitness Rating :  " + rating;
                }
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                List<string> testList = GetInputFromFiles(path);
                addToDb(testList);
                DbEntities db = new DbEntities();

            }
        }

        private List<string> GetInputFromFiles(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> memberlist = new List<string>();
            while (sr.Peek() != -1)
            {
                memberlist.Add(sr.ReadLine());
            }
            sr.Close();
            return memberlist;
        }

        private void addToDb(List<string> testList)
        {
            try
            {
                DbEntities db = new DbEntities();
                foreach (string str in testList)
                {
                    string[] wordArray = str.Split(';');
                    StepTest stepTest = new StepTest();
                    stepTest.Name = wordArray[0].ToString();
                    stepTest.Age = double.Parse(wordArray[1]);
                    stepTest.Gender = wordArray[2].ToString();
                    stepTest.Step_Height = wordArray[3].ToString();
                    stepTest.Aerobic_Capacity = double.Parse(wordArray[4]);
                    stepTest.Rating = wordArray[5].ToString();
                    stepTest.Date = wordArray[6].ToString();
                    db.StepTests.Add(stepTest);
                }
                db.SaveChanges();
            }
            catch
            {
                DialogResult dialog;
                dialog = MessageBox.Show("error in the data", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = comboBoxName.Text;
            DbEntities db = new DbEntities();
            var items = db.StepTests.Select(item => new
            {
                Name = item.Name,
                Age = item.Age,
                Gender = item.Gender,
                StepHeight = item.Step_Height,
            }
            ).ToList();
        
            for (int i = 0; i<1001; i++)
            {
                if (items[i].Name.ToString() == name)
                {
                    txtBoxAge.Text = items[i].Age.ToString();
                    comboBoxHeight.Text = items[i].StepHeight.ToString();
                    if (items[i].Gender == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    break;
                }
            }
        }
   
    }
}
