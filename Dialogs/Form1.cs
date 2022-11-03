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

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
               // this.BackColor = colorDialog1.Color;
                foreach (var item in this.Controls)
                {
                    if(item is Button bt)
                    {
                        bt.ForeColor=colorDialog1.Color;    
                    }
                    else if(item is Label lb)
                    {
                        lb.ForeColor = colorDialog1.Color;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //label1.Font = fontDialog1.Font;
                //label1.ForeColor = fontDialog1.Color;

                foreach(var item in this.Controls)
                {
                    if(item is Label lb)
                    {
                        lb.ForeColor=fontDialog1.Color;
                        lb.Font=fontDialog1.Font;
                    }
                    else if (item is Button bt)
                    {
                        bt.ForeColor = fontDialog1.Color;
                        bt.Font=fontDialog1.Font;
                    }
                    
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text=folderBrowserDialog1.SelectedPath;  
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text=File.ReadAllText(open.FileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName,richTextBox1.Text);
            }
        }
    }
}
