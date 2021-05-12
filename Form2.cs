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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            dataGridView1.DataSource = db.StepTests.ToList();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            string search = txtBoxSearch.Text;

            List<StepTest> stepTestList = db.StepTests.Where(c => c.Name.ToUpper().Contains(search)).ToList();
            populateGrid(stepTestList);

            List<StepTest> age = db.StepTests.Where(c => c.Age.ToString().ToUpper().Contains(search)).ToList();
            populateGrid(age);
        }

        private void populateGrid(List<StepTest> list)
        {
            dataGridView1.DataSource = list;
        }

       
    }
}
