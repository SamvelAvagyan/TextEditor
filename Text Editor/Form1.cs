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
    public partial class Form : System.Windows.Forms.Form
    {
        Color c;
        FontStyle f;
        bool isBold = false;
        bool isItalic = false;
        bool isUnderlined = false;
        bool isStrikeout = false;
        public Form()
        {
            InitializeComponent();
        }

        // Bold
        private void boldButtonClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                if (isBold)
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~FontStyle.Bold);
                    isBold = false;
                }
                else
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold | richTextBox.SelectionFont.Style);
                    isBold = true;
                }
            }
        }

        // Italics
        private void italicsButtonClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                if (isItalic)
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~FontStyle.Italic);
                    isItalic = false;
                }
                else
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Italic | richTextBox.SelectionFont.Style);
                    isItalic = true;
                }
            }
        }

        // UnderLine
        private void underlineButtonClick(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != "")
            {
                if (isUnderlined)
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~FontStyle.Underline);
                    isUnderlined = false;
                }
                else
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Underline | richTextBox.SelectionFont.Style);
                    isUnderlined = true;
                }
            }
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
                f = richTextBox.SelectionFont.Style;
                richTextBox.Font = fontDialog1.Font;
                richTextBox.Font = richTextBox.Font;
                richTextBox.SelectionColor = c;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, f);
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
            f = richTextBox.SelectionFont.Style;
            richTextBox.Text = richTextBox.Text.Replace(textBox1.Text, textBox2.Text);
            richTextBox.Font = new Font(richTextBox.Font, f);
            richTextBox.ForeColor = c;
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
            if (richTextBox.SelectedText != "")
            {
                if (isStrikeout)
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~FontStyle.Strikeout);
                    isStrikeout = false;
                }
                else
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Strikeout | richTextBox.SelectionFont.Style);
                    isStrikeout = true;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        // Open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            ofd.Filter = "Word Documents|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*";
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


        // Selection Text Change
        private void rtbSelectionChanged(object sender, EventArgs e)
        {
            if(richTextBox == null)
            {
                return;
            }

            tbCurrentSelection.Text = String.Format($"Position: {richTextBox.SelectionStart}, " +
                $"SelectedSymbolsCount: {richTextBox.SelectionLength}, " +
                $"SelectedText: {richTextBox.SelectedText}");
        }

        // Save File
        private void saveToolStripMenuItemClick(object sender, EventArgs e)
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

        // Exit
        private void exitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void leftButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionIndent -= 15;
        }

        private void rightButtonClick(object sender, EventArgs e)
        {
            richTextBox.SelectionIndent += 15;
        }
    }
}
