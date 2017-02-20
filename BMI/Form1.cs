using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        private MyData _data;
        public Form1()
        {

            InitializeComponent();
            _data = new MyData();
        }
        private void what(int a)
        {
            

            try
            {
                _data.high = Double.Parse(textBox1.Text);
                _data.kg = Double.Parse(textBox2.Text);


                if (a == 1)
                {

                    if (_data.kg >= 700000 || _data.high >= 300 || _data.kg <= 0 || _data.high <= 0)
                    {
                        MessageBox.Show("請輸入正常人類的體重或身高");
                        
                    }
 
                    else if (_data.Bmi() < 18.5)
                    {
                        MessageBox.Show("BMI為:" + _data.Bmi().ToString() + "   您的體位為:過輕!!!");
                        
                    }
                    else if (_data.Bmi() >= 18.5 && _data.Bmi() < 24)
                    {
                        MessageBox.Show("BMI為:" + _data.Bmi().ToString() + "   您的體位為:正常!!!");
                        
                    }
                    else if (_data.Bmi() >= 24 && _data.Bmi() < 27)
                    {
                        MessageBox.Show("BMI為:" + _data.Bmi().ToString() + "   您的體位為:過重!!!");
                       
                    }
                    else if (_data.Bmi() >= 27 && _data.Bmi() < 30)
                    {
                        MessageBox.Show("BMI為:" + _data.Bmi().ToString() + "   您的體位為:輕度肥胖!!!");
                        
                    }
                    else if (_data.Bmi() >= 30 && _data.Bmi() < 35)
                    {
                        MessageBox.Show("BMI為:" + _data.Bmi().ToString() + "   您的體位為:中度肥胖!!!");
                        
                    }
                    else if (_data.Bmi() >= 35)
                    {
                        MessageBox.Show("BMI為:" + _data.Bmi().ToString() + "   您的體位為:重度肥胖!!!");
                       
                    }
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
            catch
            {
                MessageBox.Show("請不要輸入數字以外的東西!!!!");
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            what(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            what(1);
        }
    }
}
