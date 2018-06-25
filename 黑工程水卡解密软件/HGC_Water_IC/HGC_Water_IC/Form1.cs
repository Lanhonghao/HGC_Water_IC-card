using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HGC_Water_IC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str1 = textBox1.Text;
            string str2 = str1.Substring(6,6);
            float  a=System.Int32.Parse(str2, System.Globalization.NumberStyles.HexNumber);
            string b = string.Format("{0:0.00}", a/100);
            label1.Text = b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ///<summary>
            /// 异或运算
            ///</summary>
            int x = 5;
            int y = 3;
            y ^= x;   //等价与y=y^x
            Console.WriteLine(y); ////输出结果为6
            MessageBox.Show("hello", "world!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "100";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "100";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
