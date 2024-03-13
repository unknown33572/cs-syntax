using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studyProject.winforms.lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> num = new List<int>();

            int[] num = new int[6];
            int count = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while(Array.IndexOf(num, 0) != -1)
            {
                int temp = rd.Next(1, 46);

                if (Array.IndexOf(num, temp) == -1)
                {
                    num[count] = temp;
                    sb.Append(String.Format("{0} ", temp));
                    count++;
                }
            }

            label1.Text = sb.ToString();
            listBox1.Items.Add(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int num = int.Parse(textBox1.Text);

            int checkNum = 0;
            int count = 0;

            do
            {
                checkNum = rd.Next(1, 101);
                count++;
            } while(num != checkNum);

            label2.Text = String.Format("시도횟수 : {0}", count);
        }
    }
}
