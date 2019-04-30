using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Window_Population
{
    public partial class Form1 : Form
    {
        List<string> _availableViews = new List<string>() { "DynamicView1", "DynamicView2" };
        List<BaseForm> _windows = new List<BaseForm>();

        public Form1()
        {
            InitializeComponent();

            foreach(string bv in _availableViews)
            {
                comboBox1.Items.Add(bv);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseForm bf = new BaseForm();

            switch(comboBox1.SelectedIndex)
            {
                default:
                case 0:
                    bf.View = new DynamicView1(new ViewModel1());
                    break;
                case 1:
                    bf.View = new DynamicView2(new ViewModel1());
                    break;
            }
           
            _windows.Add(bf);
            listBox1.Items.Add(bf.Name);
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach(BaseForm bf in _windows)
            //{
            //    if(bf.View.ViewModel is ViewModel1)
            //    {
            //        bf.View.ViewModel = new ViewModel2();
            //    }
            //    else
            //    {
            //        bf.View.ViewModel = new ViewModel1();
            //    }
            //}

            if(listBox1.SelectedIndex >= 0)
            {
                if (_windows[listBox1.SelectedIndex] != null)
                {
                    BaseForm selectedWindow = (BaseForm)_windows[listBox1.SelectedIndex];

                    if (selectedWindow != null)
                    {
                        if (selectedWindow.View.ViewModel is ViewModel1)
                        {
                            selectedWindow.View.ViewModel = new ViewModel2();
                        }
                        else
                        {
                            selectedWindow.View.ViewModel = new ViewModel1();
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //foreach (BaseForm bf in _windows)
            //{
            //    if (bf.View is DynamicView1)
            //    {
            //        bf.View = new DynamicView2(new ViewModel1());
            //    }
            //    else
            //    {
            //        bf.View = new DynamicView1(new ViewModel1());
            //    }
            //}

            if (listBox1.SelectedIndex >= 0)
            {
                if (_windows[listBox1.SelectedIndex] != null)
                {
                    BaseForm selectedWindow = (BaseForm)_windows[listBox1.SelectedIndex];

                    if (selectedWindow != null)
                    {
                        if (selectedWindow.View is DynamicView1)
                        {
                            selectedWindow.View = new DynamicView2(new ViewModel1());
                        }
                        else
                        {
                            selectedWindow.View = new DynamicView1(new ViewModel1());
                        }
                    }
                }
            }              
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_windows[listBox1.SelectedIndex] != null)
            {

            }
        }
    }
}
