using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            label1.Visible = false;
            listView1.Visible = false;
            button8.Visible = false;
            webBrowser1.Navigate(textBox1.Text);
            list.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible=false;
            label1.Visible = true;
            listView1.Visible = true;
            button8.Visible = true;
            foreach (string item in list)
            {
                listView1.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Clear();
            listView1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
