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
    public partial class form1 : System.Windows.Forms.Form
    {
        Color c;
        public form1()
        {
            InitializeComponent();
        }

        // Bold
        private void boldButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | richTextBox.SelectionFont.Style);
        }

        // Save File
        private void saveButtonClick(object sender, EventArgs e)
        {
            sfd.FileName = ofd.FileName;
            sfd.Filter = "Word Documents|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter Writer = new StreamWriter(sfd.FileName, false, Encoding.GetEncoding(1251)))
                    {
                        Writer.Write(richTextBox.Text);
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
        private void italicsButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | richTextBox.SelectionFont.Style);
        }

        // UnderLine
        private void underlineButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Underline | richTextBox.SelectionFont.Style);
        }

        // Text Align Left
        private void textAlignLeftButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Text Align Right
        private void textAlignRightButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        // Text Align Center
        private void textAlignCenterButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Font Style
        private void fontButtonClick(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fontDialog1.Font;
                richTextBox.ForeColor = c;
                richTextBox.Font = richTextBox.Font;
            }
        }

        // Text Color
        private void textColorButtonClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText == "")
                {
                    richTextBox.ForeColor = colorDialog1.Color;
                    c = colorDialog1.Color;
                }

                richTextBox.SelectionColor = colorDialog1.Color;
                c = colorDialog1.Color;
            }
        }

        // Background Color
        private void backgroundColorButtonClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.BackColor = colorDialog1.Color;
            }
        }

        // Open File
        private void openButtonClick(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            ofd.Filter = "Word Documents|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*"; //"txt files (*.txt)|*.txt|All files (*.*)|*.*"
            formLoad(sender, e);

            if (ofd.FileName == String.Empty) return;

            try
            {
                using (StreamReader SReader = new StreamReader(ofd.FileName, Encoding.GetEncoding(1251)))
                {
                    richTextBox.Text = SReader.ReadToEnd();
                    SReader.Close();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void formLoad(object sender, EventArgs e)
        {
            Text = $"Text Editor - {ofd.FileName}";
        }

        private void richTextBoxTextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void replaceButtonClick(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text.Replace(textBox1.Text, textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void changingTextClick(object sender, EventArgs e)
        {

        }

        private void positioningTextClick(object sender, EventArgs e)
        {

        }

        // Strikeout
        private void strikeoutButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Strikeout | richTextBox.SelectionFont.Style);
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
