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
        List<string> history = new List<string>();
        List<string> tabs = new List<string>();

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
            history.Add(textBox1.Text);
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
            label1.Text = "История";
            label1.Visible = true;
            listView1.Visible = true;
            button8.Visible = true;
            foreach (string item in history)
            {
                listView1.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            history.Clear();
            listView1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tabs.Contains(textBox1.Text)==false)
            {
                tabs.Add(textBox1.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabs.Remove(textBox1.Text);
            listView1.Clear();
            foreach (string item in tabs)
            {
                listView1.Items.Add(item);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            button8.Visible = false;
            label1.Text = "Закладки";
            label1.Visible = true;
            listView1.Clear();
            listView1.Visible = true;
            foreach (string item in tabs)
            {
                listView1.Items.Add(item);
            }
        }
        private void Tabs_select(object sender, EventArgs e)
        {
            if(label1.Text=="Закладки")
            {
                webBrowser1.Navigate(listView1.SelectedItems[0].Text);
                listView1.Visible = false;
                webBrowser1.Visible=true;
            }
        }
    }
}
