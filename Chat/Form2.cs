using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 owner)
        {
            f1 = owner;
            InitializeComponent();
        }

        public Color Color
        {
            get { return View2.SelectionColor; }
            set { View2.SelectionColor = value; }
        }
        public string Data
        {
            get { return textBox1.Text; }
            set { View2.AppendText(value + "\n"); }
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            string to = but.Tag.ToString();
            string from = but.Parent.Text;
            f1.DataCenter(textBox1.Text, to, from);
        }
    }



}
