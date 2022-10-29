namespace AppDevDotNetTask2
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.topToolbar = new System.Windows.Forms.ToolStrip();
            this.newFileButton = new System.Windows.Forms.ToolStripButton();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlineButton = new System.Windows.Forms.ToolStripButton();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loggedInLabel = new System.Windows.Forms.ToolStripLabel();
            this.leftToolbar = new System.Windows.Forms.ToolStrip();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.topFileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.topToolbar.SuspendLayout();
            this.leftToolbar.SuspendLayout();
            this.topFileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topToolbar
            // 
            this.topToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileButton,
            this.openFileButton,
            this.saveFileButton,
            this.saveAsButton,
            this.toolStripSeparator1,
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.fontComboBox,
            this.helpButton,
            this.toolStripSeparator2,
            this.loggedInLabel});
            this.topToolbar.Location = new System.Drawing.Point(0, 24);
            this.topToolbar.Name = "topToolbar";
            this.topToolbar.Size = new System.Drawing.Size(945, 25);
            this.topToolbar.TabIndex = 0;
            this.topToolbar.Text = "toolStrip1";
            // 
            // newFileButton
            // 
            this.newFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFileButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileButton.Image")));
            this.newFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(23, 22);
            this.newFileButton.Text = "New File";
            this.newFileButton.Click += new System.EventHandler(this.NewFile);
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(23, 22);
            this.openFileButton.Text = "Open File";
            this.openFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(23, 22);
            this.saveFileButton.Text = "Save";
            this.saveFileButton.Click += new System.EventHandler(this.Save);
            // 
            // saveAsButton
            // 
            this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(23, 22);
            this.saveAsButton.Text = "Save As";
            this.saveAsButton.Click += new System.EventHandler(this.SaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(23, 22);
            this.boldButton.Text = "Bold";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(23, 22);
            this.italicButton.Text = "Italic";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlineButton
            // 
            this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
            this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(23, 22);
            this.underlineButton.Text = "Underline";
            this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
            // 
            // fontComboBox
            // 
            this.fontComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 25);
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            this.fontComboBox.TextUpdate += new System.EventHandler(this.fontComboBox_TextUpdate);
            this.fontComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fontComboBox_KeyPress);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 22);
            this.helpButton.Text = "Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(93, 22);
            this.loggedInLabel.Text = "User Name: Jack";
            // 
            // leftToolbar
            // 
            this.leftToolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutButton,
            this.copyButton,
            this.pasteButton});
            this.leftToolbar.Location = new System.Drawing.Point(0, 49);
            this.leftToolbar.Name = "leftToolbar";
            this.leftToolbar.Size = new System.Drawing.Size(24, 543);
            this.leftToolbar.TabIndex = 1;
            this.leftToolbar.Text = "toolStrip2";
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(21, 20);
            this.cutButton.Text = "Cut";
            this.cutButton.Click += new System.EventHandler(this.Cut);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(21, 20);
            this.copyButton.Text = "Copy";
            this.copyButton.Click += new System.EventHandler(this.Copy);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(21, 20);
            this.pasteButton.Text = "Paste";
            this.pasteButton.Click += new System.EventHandler(this.Paste);
            // 
            // topFileMenuStrip
            // 
            this.topFileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topFileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topFileMenuStrip.Name = "topFileMenuStrip";
            this.topFileMenuStrip.Size = new System.Drawing.Size(945, 24);
            this.topFileMenuStrip.TabIndex = 2;
            this.topFileMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileItem,
            this.openFileItem,
            this.toolStripSeparator3,
            this.saveFileItem,
            this.saveAsItem,
            this.toolStripSeparator4,
            this.logoutItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileItem
            // 
            this.newFileItem.Image = ((System.Drawing.Image)(resources.GetObject("newFileItem.Image")));
            this.newFileItem.Name = "newFileItem";
            this.newFileItem.Size = new System.Drawing.Size(114, 22);
            this.newFileItem.Text = "New";
            this.newFileItem.Click += new System.EventHandler(this.NewFile);
            // 
            // openFileItem
            // 
            this.openFileItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileItem.Image")));
            this.openFileItem.Name = "openFileItem";
            this.openFileItem.Size = new System.Drawing.Size(114, 22);
            this.openFileItem.Text = "Open";
            this.openFileItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // saveFileItem
            // 
            this.saveFileItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileItem.Image")));
            this.saveFileItem.Name = "saveFileItem";
            this.saveFileItem.Size = new System.Drawing.Size(114, 22);
            this.saveFileItem.Text = "Save";
            this.saveFileItem.Click += new System.EventHandler(this.Save);
            // 
            // saveAsItem
            // 
            this.saveAsItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsItem.Image")));
            this.saveAsItem.Name = "saveAsItem";
            this.saveAsItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsItem.Text = "Save As";
            this.saveAsItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(111, 6);
            // 
            // logoutItem
            // 
            this.logoutItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutItem.Image")));
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(114, 22);
            this.logoutItem.Text = "Logout";
            this.logoutItem.Click += new System.EventHandler(this.logoutItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutItem,
            this.copyItem,
            this.pasteItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutItem
            // 
            this.cutItem.Image = ((System.Drawing.Image)(resources.GetObject("cutItem.Image")));
            this.cutItem.Name = "cutItem";
            this.cutItem.Size = new System.Drawing.Size(102, 22);
            this.cutItem.Text = "Cut";
            this.cutItem.Click += new System.EventHandler(this.Cut);
            // 
            // copyItem
            // 
            this.copyItem.Image = ((System.Drawing.Image)(resources.GetObject("copyItem.Image")));
            this.copyItem.Name = "copyItem";
            this.copyItem.Size = new System.Drawing.Size(102, 22);
            this.copyItem.Text = "Copy";
            this.copyItem.Click += new System.EventHandler(this.Copy);
            // 
            // pasteItem
            // 
            this.pasteItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteItem.Image")));
            this.pasteItem.Name = "pasteItem";
            this.pasteItem.Size = new System.Drawing.Size(102, 22);
            this.pasteItem.Text = "Paste";
            this.pasteItem.Click += new System.EventHandler(this.Paste);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(180, 22);
            this.aboutItem.Text = "About...";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(27, 52);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(906, 528);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            this.textBox.SelectionChanged += new System.EventHandler(this.textBox_SelectionChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files|*.txt;*.rtf";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Rich Text Files|*.rtf";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 592);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.leftToolbar);
            this.Controls.Add(this.topToolbar);
            this.Controls.Add(this.topFileMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topFileMenuStrip;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "TextEditor";
            this.Text = "Secured Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_FormClosing);
            this.topToolbar.ResumeLayout(false);
            this.topToolbar.PerformLayout();
            this.leftToolbar.ResumeLayout(false);
            this.leftToolbar.PerformLayout();
            this.topFileMenuStrip.ResumeLayout(false);
            this.topFileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip topToolbar;
        private System.Windows.Forms.ToolStripButton newFileButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripButton saveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlineButton;
        private System.Windows.Forms.ToolStripComboBox fontComboBox;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel loggedInLabel;
        private System.Windows.Forms.ToolStrip leftToolbar;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.MenuStrip topFileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileItem;
        private System.Windows.Forms.ToolStripMenuItem openFileItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveFileItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutItem;
        private System.Windows.Forms.ToolStripMenuItem copyItem;
        private System.Windows.Forms.ToolStripMenuItem pasteItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

