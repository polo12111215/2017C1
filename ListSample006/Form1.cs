using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample006
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDataSource();
            ChangData();
        }
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫","狼","羊","草"
            };
            _rightList = new List<string>();

        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;

        }
        private void ChangData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() == "農夫")
                {

                    _leftList.Remove("農夫");
                    _rightList.Add("農夫");
                    ChangData();
                }
                else
                {
                    if (_leftList.Contains("農夫"))
                    {
                        _leftList.Remove("農夫");
                        _rightList.Add("農夫");
                        string item1 = listBox1.SelectedItem.ToString();
                        _leftList.Remove(item1);
                        _rightList.Add(item1);
                        ChangData();
                    }

                }

                if (_rightList.Contains("草") && _rightList.Contains("羊") && _rightList.Contains("農夫") && _rightList.Contains("狼"))
                {
                    MessageBox.Show("你贏了!!成功渡河!!!");
                    CreateList();
                    SetListBoxDataSource();
                    ChangData();
                }
                if (_leftList.Contains("農夫") == false)
                {
                    if (_leftList.Contains("狼") && _leftList.Contains("羊"))
                    {
                        MessageBox.Show("你輸了!!羊被狼吃掉了!!!");
                        CreateList();
                        SetListBoxDataSource();
                        ChangData();

                    }
                    else if (_leftList.Contains("草") && _leftList.Contains("羊"))
                    {
                        MessageBox.Show("你輸了!!草被羊吃掉了!!!");
                        CreateList();
                        SetListBoxDataSource();
                        ChangData();
                    }
                }
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem.ToString() == "農夫")
                {

                    _leftList.Add("農夫");
                    _rightList.Remove("農夫");
                    ChangData();
                }

                else
                {
                    if (_rightList.Contains("農夫"))
                    {
                        _leftList.Add("農夫");
                        _rightList.Remove("農夫");
                        string item1 = listBox2.SelectedItem.ToString();
                        _leftList.Add(item1);
                        _rightList.Remove(item1);
                        ChangData();
                    }

                }
                if (_rightList.Contains("狼") && _rightList.Contains("羊"))
                {
                    MessageBox.Show("你輸了!!羊被狼吃掉了!!!");
                    CreateList();
                    SetListBoxDataSource();
                    ChangData();
                }
                if (_rightList.Contains("草") && _rightList.Contains("羊"))
                {
                    MessageBox.Show("你輸了!!草被羊吃掉了!!!");
                    CreateList();
                    SetListBoxDataSource();
                    ChangData();
                }
            }
            catch
            {
            }
        }
    }
}
