using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppDevDotNetTask2
{
    public partial class TextEditor : Form
    {
        public string currentFile = "";

        public TextEditor()
        {
            InitializeComponent();
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void newFileItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveFileItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void saveAsItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        void NewFile()
        {
            textBox.Text = "";
            currentFile = "";
        }

        void SaveFile()
        {
            if (currentFile == "")
            {
                SaveAsFile();
            }
            else
            {
                string newFilePath = Path.Combine(Path.GetDirectoryName(currentFile), Path.GetFileNameWithoutExtension(currentFile) + ".rtf");
                Console.WriteLine(newFilePath);
                textBox.SaveFile(newFilePath);
            }
        }

        void SaveAsFile()
        {
            if (currentFile != "")
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(currentFile);
                saveFileDialog.FileName = Path.GetFileName(currentFile);
            }
            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog.FileName;
            if (fileName != "")
            {
                currentFile = fileName;
                if (fileName.ToLower().Contains(".txt"))
                {
                    textBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (fileName.ToLower().Contains(".rtf"))
                {
                    textBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox.SaveFile(saveFileDialog.FileName);
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            Font f = textBox.SelectionFont;
            updateStyle(!f.Bold, f.Italic, f.Underline);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font f = textBox.SelectionFont;
            updateStyle(f.Bold, !f.Italic, f.Underline);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            Font f = textBox.SelectionFont;
            updateStyle(f.Bold, f.Italic, !f.Underline);
        }

        private void updateStyle(bool bold, bool italic, bool underline)
        {
            FontStyle style = FontStyle.Regular;
            if (bold)
            {
                style = style | FontStyle.Bold;
            }
            if (italic)
            {
                style = style | FontStyle.Italic;
            }
            if (underline)
            {
                style = style | FontStyle.Underline;
            }
            textBox.SelectionFont = new Font(textBox.Font, style);
            textBox.Focus();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }
    }
}
