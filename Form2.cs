using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        private void populateGrid(List<StepTest> list)
        {
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            var records = from m in db.StepTests
                          select m;
            foreach (var record in records)
            {
                db.StepTests.Remove(record);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.StepTests.ToList();

        }

        private void label1_Click(object sender, EventArgs e)
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
                populateGrid(db.StepTests.ToList());
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
    }
}
