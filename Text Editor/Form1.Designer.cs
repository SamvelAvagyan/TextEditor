namespace Text_Editor
{
    partial class form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.changingText = new System.Windows.Forms.Label();
            this.positioningText = new System.Windows.Forms.Label();
            this.strikeoutButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.textColor = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.textAlignCenterButton = new System.Windows.Forms.Button();
            this.textAlignRightButton = new System.Windows.Forms.Button();
            this.textAlignLeftButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.italicsButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 41);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(784, 397);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBoxTextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(64, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(46, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(48, 23);
            this.openButton.TabIndex = 12;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(682, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // changingText
            // 
            this.changingText.AutoSize = true;
            this.changingText.Location = new System.Drawing.Point(444, 16);
            this.changingText.Name = "changingText";
            this.changingText.Size = new System.Drawing.Size(72, 13);
            this.changingText.TabIndex = 15;
            this.changingText.Text = "Changing text";
            this.changingText.Click += new System.EventHandler(this.changingTextClick);
            // 
            // positioningText
            // 
            this.positioningText.AutoSize = true;
            this.positioningText.Location = new System.Drawing.Point(603, 16);
            this.positioningText.Name = "positioningText";
            this.positioningText.Size = new System.Drawing.Size(78, 13);
            this.positioningText.TabIndex = 16;
            this.positioningText.Text = "Positioning text";
            this.positioningText.Click += new System.EventHandler(this.positioningTextClick);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.Image = global::Text_Editor.Properties.Resources.Line;
            this.strikeoutButton.Location = new System.Drawing.Point(205, 11);
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(35, 24);
            this.strikeoutButton.TabIndex = 18;
            this.strikeoutButton.UseVisualStyleBackColor = true;
            this.strikeoutButton.Click += new System.EventHandler(this.strikeoutButtonClick);
            // 
            // replaceButton
            // 
            this.replaceButton.Image = global::Text_Editor.Properties.Resources.ReplaceIcon1;
            this.replaceButton.Location = new System.Drawing.Point(770, 11);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(26, 23);
            this.replaceButton.TabIndex = 17;
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButtonClick);
            // 
            // backgroundColor
            // 
            this.backgroundColor.Image = global::Text_Editor.Properties.Resources.BackgroundColor;
            this.backgroundColor.Location = new System.Drawing.Point(372, 11);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(32, 23);
            this.backgroundColor.TabIndex = 11;
            this.backgroundColor.UseVisualStyleBackColor = true;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColorButtonClick);
            // 
            // textColor
            // 
            this.textColor.Image = global::Text_Editor.Properties.Resources.TextColor;
            this.textColor.Location = new System.Drawing.Point(339, 11);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(27, 23);
            this.textColor.TabIndex = 10;
            this.textColor.UseVisualStyleBackColor = true;
            this.textColor.Click += new System.EventHandler(this.textColorButtonClick);
            // 
            // fontButton
            // 
            this.fontButton.Image = global::Text_Editor.Properties.Resources.TextFont;
            this.fontButton.Location = new System.Drawing.Point(410, 11);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(29, 23);
            this.fontButton.TabIndex = 9;
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButtonClick);
            // 
            // textAlignCenterButton
            // 
            this.textAlignCenterButton.Image = global::Text_Editor.Properties.Resources.CenterAlign1;
            this.textAlignCenterButton.Location = new System.Drawing.Point(277, 11);
            this.textAlignCenterButton.Name = "textAlignCenterButton";
            this.textAlignCenterButton.Size = new System.Drawing.Size(25, 23);
            this.textAlignCenterButton.TabIndex = 7;
            this.textAlignCenterButton.UseVisualStyleBackColor = true;
            this.textAlignCenterButton.Click += new System.EventHandler(this.textAlignCenterButtonClick);
            // 
            // textAlignRightButton
            // 
            this.textAlignRightButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAlignRightButton.Image = global::Text_Editor.Properties.Resources.RightAlign;
            this.textAlignRightButton.Location = new System.Drawing.Point(307, 11);
            this.textAlignRightButton.Name = "textAlignRightButton";
            this.textAlignRightButton.Size = new System.Drawing.Size(26, 23);
            this.textAlignRightButton.TabIndex = 6;
            this.textAlignRightButton.UseVisualStyleBackColor = false;
            this.textAlignRightButton.Click += new System.EventHandler(this.textAlignRightButtonClick);
            // 
            // textAlignLeftButton
            // 
            this.textAlignLeftButton.Image = global::Text_Editor.Properties.Resources.LeftAlign;
            this.textAlignLeftButton.Location = new System.Drawing.Point(246, 11);
            this.textAlignLeftButton.Name = "textAlignLeftButton";
            this.textAlignLeftButton.Size = new System.Drawing.Size(25, 23);
            this.textAlignLeftButton.TabIndex = 5;
            this.textAlignLeftButton.UseVisualStyleBackColor = true;
            this.textAlignLeftButton.Click += new System.EventHandler(this.textAlignLeftButtonClick);
            // 
            // underlineButton
            // 
            this.underlineButton.Image = global::Text_Editor.Properties.Resources.UnderLine1;
            this.underlineButton.Location = new System.Drawing.Point(176, 12);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 23);
            this.underlineButton.TabIndex = 4;
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButtonClick);
            // 
            // italicsButton
            // 
            this.italicsButton.Image = global::Text_Editor.Properties.Resources.Kursiv;
            this.italicsButton.Location = new System.Drawing.Point(147, 12);
            this.italicsButton.Name = "italicsButton";
            this.italicsButton.Size = new System.Drawing.Size(23, 23);
            this.italicsButton.TabIndex = 3;
            this.italicsButton.UseVisualStyleBackColor = true;
            this.italicsButton.Click += new System.EventHandler(this.italicsButtonClick);
            // 
            // boldButton
            // 
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.Location = new System.Drawing.Point(115, 12);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(26, 23);
            this.boldButton.TabIndex = 0;
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButtonClick);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.strikeoutButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.positioningText);
            this.Controls.Add(this.changingText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.backgroundColor);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.textAlignCenterButton);
            this.Controls.Add(this.textAlignRightButton);
            this.Controls.Add(this.textAlignLeftButton);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.italicsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.boldButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 489);
            this.MinimumSize = new System.Drawing.Size(823, 489);
            this.Name = "form1";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.formLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button italicsButton;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button textAlignLeftButton;
        private System.Windows.Forms.Button textAlignRightButton;
        private System.Windows.Forms.Button textAlignCenterButton;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button textColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label changingText;
        private System.Windows.Forms.Label positioningText;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button strikeoutButton;
    }
}

