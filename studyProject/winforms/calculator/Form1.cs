using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyProject.winforms.calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputBox1.Text);
            int num2 = int.Parse(inputBox2.Text);

            int result = num1 + num2;

            resultBox.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputBox1.Text);
            int num2 = int.Parse(inputBox2.Text);

            int result = num1 - num2;

            resultBox.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputBox1.Text);
            int num2 = int.Parse(inputBox2.Text);

            int result = num1 * num2;

            resultBox.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputBox1.Text);
            int num2 = int.Parse(inputBox2.Text);

            int result = num1 / num2;

            resultBox.Text = result.ToString();
        }
    }
}
