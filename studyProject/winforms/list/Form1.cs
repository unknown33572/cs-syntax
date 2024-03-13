using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyProject.winforms.list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum enumDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private enum enumTime
        {
            Morning,
            Lunch,
            Afternoon,
            Evening,
            Night
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(enumDays.Monday);
            listBox1.Items.Add(enumDays.Tuesday);
            listBox1.Items.Add(enumDays.Wednesday);
            listBox1.Items.Add(enumDays.Thursday);
            listBox1.Items.Add(enumDays.Friday);
            listBox1.Items.Add(enumDays.Saturday);
            listBox1.Items.Add(enumDays.Sunday);

            listBox2.Items.Add(enumTime.Morning);
            listBox2.Items.Add(enumTime.Lunch);
            listBox2.Items.Add(enumTime.Afternoon);
            listBox2.Items.Add(enumTime.Evening);
            listBox2.Items.Add(enumTime.Night);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strResult = listBox1.SelectedItem.ToString() + " " + listBox2.SelectedItem.ToString();

            textBox1.Text = strResult;
        }
    }
}
