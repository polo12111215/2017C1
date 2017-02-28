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

namespace NameAndPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var list = CreateData();
            dataGridView1.DataSource = list;
        }
        private List<MyData > CreateData()
        {

            Char[] splits = new char[] { ',' };

            string fileName = "123.csv";
            List<MyData > result = new List<MyData >();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(splits);
                    var MyData = new MyData
                    {
                        Name  = items[0],
                        Phone  =items[1],
                        Sex  = items[2],
                       
                    };
                    result.Add(MyData);

                }
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = CreateData();
            var input = textBox1.Text;
            
            var person = list.SingleOrDefault((result) => result.Name == input);
            if (person == null)
            {
                MessageBox.Show("查無此人!!!!");
            }
            else
            {
                MessageBox.Show("你找到的人為:" + person.Name + " 電話是:" + person.Phone + " 性別是:" + person.Sex);
            }
            textBox1.Clear();
        }
    }
}
