using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator03
{
    public partial class Form1 : Form
    {
        private MyData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new MyData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(1);
        }
        private void Calculate(float  a)
        {
            _data.X = float .Parse(textBox1.Text);
            _data.Y  = float.Parse(textBox2.Text);
            if (a == 1)
            {
                label1.Text = _data.Add().ToString();
            }
            else if (a == 2)
            {
                
                    label1.Text = _data.Less().ToString();
                
            }
            else if (a == 3)
            {
                label1.Text = _data.aaa().ToString();
            }

            else if (a == 4)
            {
                label1.Text = _data.bbb().ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate(4);
        }
    }
}
