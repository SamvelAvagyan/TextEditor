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

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bold
        private void button1_Click(object sender, EventArgs e)
        {
            Font f = richTextBox1.Font;

            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(f, FontStyle.Bold);
                              
            }
            else
            {

                richTextBox1.Font = new Font(f, FontStyle.Bold);
            }
        }

        // Save File
        private void button2_Click(object sender, EventArgs e)
        {
            sfd.FileName = ofd.FileName;
            sfd.Filter = "Word Documents|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter Writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding(1251)))
                    {
                        Writer.Write(richTextBox1.Text);
                        Writer.Close();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        // Italics
        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            }
        }

        // UnderLine
        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
            }
        }

        // Text Align Left
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Text Align Right
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        // Text Align Center
        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Font Style
        private void button9_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        // Text Color
        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText == "")
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }
        }

        // Background Color
        private void button11_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        // Open File
        private void button12_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            ofd.Filter = "Word Documents|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*"; //"txt files (*.txt)|*.txt|All files (*.*)|*.*"

            if (ofd.FileName == String.Empty) return;

            try
            {
                using (StreamReader SReader = new StreamReader(ofd.FileName, Encoding.GetEncoding(1251)))
                {
                    richTextBox1.Text = SReader.ReadToEnd();
                    SReader.Close();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(textBox1.Text, textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Strikeout
        private void button13_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText == "")
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Strikeout);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Strikeout);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
