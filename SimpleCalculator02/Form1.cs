using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        public  Double a, b;
        public int z = 0;
        public Form1()
        {
             
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);
                label1.Text = (a + b).ToString();
            

        }
    
        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
