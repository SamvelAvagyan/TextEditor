namespace Text_Editor
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.changingText = new System.Windows.Forms.Label();
            this.positioningText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.strikeoutButton = new System.Windows.Forms.Button();
            this.italicsButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            this.textAlignLeftButton = new System.Windows.Forms.Button();
            this.textAlignRightButton = new System.Windows.Forms.Button();
            this.textAlignCenterButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.textColor = new System.Windows.Forms.Button();
            this.tbCurrentSelection = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(148, 69);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(460, 397);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.rtbSelectionChanged);
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBoxTextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(658, 11);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // changingText
            // 
            this.changingText.AutoSize = true;
            this.changingText.Location = new System.Drawing.Point(420, 14);
            this.changingText.Name = "changingText";
            this.changingText.Size = new System.Drawing.Size(72, 13);
            this.changingText.TabIndex = 15;
            this.changingText.Text = "Changing text";
            this.changingText.Click += new System.EventHandler(this.changingTextClick);
            // 
            // positioningText
            // 
            this.positioningText.AutoSize = true;
            this.positioningText.Location = new System.Drawing.Point(579, 14);
            this.positioningText.Name = "positioningText";
            this.positioningText.Size = new System.Drawing.Size(78, 13);
            this.positioningText.TabIndex = 16;
            this.positioningText.Text = "Positioning text";
            this.positioningText.Click += new System.EventHandler(this.positioningTextClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItemClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightButton);
            this.groupBox1.Controls.Add(this.leftButton);
            this.groupBox1.Controls.Add(this.boldButton);
            this.groupBox1.Controls.Add(this.strikeoutButton);
            this.groupBox1.Controls.Add(this.italicsButton);
            this.groupBox1.Controls.Add(this.replaceButton);
            this.groupBox1.Controls.Add(this.underlineButton);
            this.groupBox1.Controls.Add(this.positioningText);
            this.groupBox1.Controls.Add(this.textAlignLeftButton);
            this.groupBox1.Controls.Add(this.changingText);
            this.groupBox1.Controls.Add(this.textAlignRightButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textAlignCenterButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.fontButton);
            this.groupBox1.Controls.Add(this.backgroundColor);
            this.groupBox1.Controls.Add(this.textColor);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 36);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // rightButton
            // 
            this.rightButton.BackgroundImage = global::Text_Editor.Properties.Resources.rightButton;
            this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightButton.Location = new System.Drawing.Point(385, 9);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(29, 23);
            this.rightButton.TabIndex = 20;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButtonClick);
            // 
            // leftButton
            // 
            this.leftButton.BackgroundImage = global::Text_Editor.Properties.Resources.leftButton;
            this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftButton.Location = new System.Drawing.Point(350, 9);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(29, 23);
            this.leftButton.TabIndex = 19;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButtonClick);
            // 
            // boldButton
            // 
            this.boldButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.Location = new System.Drawing.Point(20, 10);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(26, 23);
            this.boldButton.TabIndex = 0;
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButtonClick);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.strikeoutButton.Image = global::Text_Editor.Properties.Resources.Line;
            this.strikeoutButton.Location = new System.Drawing.Point(110, 9);
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(35, 24);
            this.strikeoutButton.TabIndex = 18;
            this.strikeoutButton.UseVisualStyleBackColor = true;
            this.strikeoutButton.Click += new System.EventHandler(this.strikeoutButtonClick);
            // 
            // italicsButton
            // 
            this.italicsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.italicsButton.Image = global::Text_Editor.Properties.Resources.Kursiv;
            this.italicsButton.Location = new System.Drawing.Point(52, 10);
            this.italicsButton.Name = "italicsButton";
            this.italicsButton.Size = new System.Drawing.Size(23, 23);
            this.italicsButton.TabIndex = 3;
            this.italicsButton.UseVisualStyleBackColor = true;
            this.italicsButton.Click += new System.EventHandler(this.italicsButtonClick);
            // 
            // replaceButton
            // 
            this.replaceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replaceButton.Image = global::Text_Editor.Properties.Resources.ReplaceIcon1;
            this.replaceButton.Location = new System.Drawing.Point(746, 9);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(26, 23);
            this.replaceButton.TabIndex = 17;
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButtonClick);
            // 
            // underlineButton
            // 
            this.underlineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.underlineButton.Image = global::Text_Editor.Properties.Resources.UnderLine1;
            this.underlineButton.Location = new System.Drawing.Point(81, 10);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 23);
            this.underlineButton.TabIndex = 4;
            this.underlineButton.UseVisualStyleBackColor = true;
            this.underlineButton.Click += new System.EventHandler(this.underlineButtonClick);
            // 
            // textAlignLeftButton
            // 
            this.textAlignLeftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textAlignLeftButton.Image = global::Text_Editor.Properties.Resources.LeftAlign;
            this.textAlignLeftButton.Location = new System.Drawing.Point(151, 9);
            this.textAlignLeftButton.Name = "textAlignLeftButton";
            this.textAlignLeftButton.Size = new System.Drawing.Size(25, 23);
            this.textAlignLeftButton.TabIndex = 5;
            this.textAlignLeftButton.UseVisualStyleBackColor = true;
            this.textAlignLeftButton.Click += new System.EventHandler(this.textAlignLeftButtonClick);
            // 
            // textAlignRightButton
            // 
            this.textAlignRightButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAlignRightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textAlignRightButton.Image = global::Text_Editor.Properties.Resources.RightAlign;
            this.textAlignRightButton.Location = new System.Drawing.Point(212, 9);
            this.textAlignRightButton.Name = "textAlignRightButton";
            this.textAlignRightButton.Size = new System.Drawing.Size(26, 23);
            this.textAlignRightButton.TabIndex = 6;
            this.textAlignRightButton.UseVisualStyleBackColor = false;
            this.textAlignRightButton.Click += new System.EventHandler(this.textAlignRightButtonClick);
            // 
            // textAlignCenterButton
            // 
            this.textAlignCenterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textAlignCenterButton.Image = global::Text_Editor.Properties.Resources.CenterAlign1;
            this.textAlignCenterButton.Location = new System.Drawing.Point(182, 9);
            this.textAlignCenterButton.Name = "textAlignCenterButton";
            this.textAlignCenterButton.Size = new System.Drawing.Size(25, 23);
            this.textAlignCenterButton.TabIndex = 7;
            this.textAlignCenterButton.UseVisualStyleBackColor = true;
            this.textAlignCenterButton.Click += new System.EventHandler(this.textAlignCenterButtonClick);
            // 
            // fontButton
            // 
            this.fontButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fontButton.Image = global::Text_Editor.Properties.Resources.TextFont;
            this.fontButton.Location = new System.Drawing.Point(315, 9);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(29, 23);
            this.fontButton.TabIndex = 9;
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButtonClick);
            // 
            // backgroundColor
            // 
            this.backgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backgroundColor.Image = global::Text_Editor.Properties.Resources.BackgroundColor;
            this.backgroundColor.Location = new System.Drawing.Point(277, 9);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(32, 23);
            this.backgroundColor.TabIndex = 11;
            this.backgroundColor.UseVisualStyleBackColor = true;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColorButtonClick);
            // 
            // textColor
            // 
            this.textColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textColor.Image = global::Text_Editor.Properties.Resources.TextColor;
            this.textColor.Location = new System.Drawing.Point(244, 9);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(27, 23);
            this.textColor.TabIndex = 10;
            this.textColor.UseVisualStyleBackColor = true;
            this.textColor.Click += new System.EventHandler(this.textColorButtonClick);
            // 
            // tbCurrentSelection
            // 
            this.tbCurrentSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentSelection.Location = new System.Drawing.Point(614, 69);
            this.tbCurrentSelection.Multiline = true;
            this.tbCurrentSelection.Name = "tbCurrentSelection";
            this.tbCurrentSelection.ReadOnly = true;
            this.tbCurrentSelection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCurrentSelection.Size = new System.Drawing.Size(181, 203);
            this.tbCurrentSelection.TabIndex = 24;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 486);
            this.Controls.Add(this.tbCurrentSelection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 525);
            this.MinimumSize = new System.Drawing.Size(823, 525);
            this.Name = "Form";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.formLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.RichTextBox richTextBox;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label changingText;
        private System.Windows.Forms.Label positioningText;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button strikeoutButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.TextBox tbCurrentSelection;
    }
}

