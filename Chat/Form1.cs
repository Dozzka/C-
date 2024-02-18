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
    public partial class Form1 : Form
    {
        Form2 f2;
        Form3 f3;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2(this);
            f2.Show();
            f3 = new Form3(this);
            f3.Show();
        }
    public string Data
        {
            get { return textBox1.Text; }
            set { View1.AppendText(value + "\n"); }
        }
        public void DataCenter(string text, string to, string from) 
        {
            Color color;
            switch (from) 
            {
                case "Form1": color = Color.Blue; break;
                case "Form2": color = Color.Red; break;
                case "Form3": color = Color.Purple; break;
                default: color = Color.Black; break;

            }
            switch (to)
            {
                case "To1":
                    View1.SelectionColor = color;
                    this.Data = $"{DateTime.Now} Отправитель:{from} \n{text}";
                    break;
                case "To2":
                    try
                    {
                        f2.Color = color;
                        f2.Data = $"{DateTime.Now} Отправитель:{from} \n{text}"; 
                    }
                    catch 
                    { 
                        f2 = new Form2(this);
                        f2.Color = color;
                        f2.Data = this.textBox1.Text;
                        f2.Show();
                    }
                    break;
                case "To3":
                    try 
                    {
                        f3.Color = color;
                        f3.Data = $"{DateTime.Now} Отправитель:{from} \n{text}";
                    }
                    catch
                    {
                        f3 = new Form3(this);
                        f3.Color = color;
                        f3.Data = this.textBox1.Text;
                        f3.Show();
                    }
                    break;

            }
        
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            string to = but.Tag.ToString();
            string from = but.Parent.Text;
            DataCenter(textBox1.Text, to, from);
        }

    }
}
