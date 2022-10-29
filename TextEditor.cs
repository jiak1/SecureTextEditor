using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AppDevDotNetTask2
{
    public partial class TextEditor : Form
    {
        // The current file loaded in the editor
        private string currentFile = "";
        // The parent form that created this, typically login
        private Form parent;
        // The account we are logged in with
        private Account account;
        // Whether the next time we click in the text box we should apply a font size change
        private Font newSizeFont = null;

        /// <summary>
        /// This constructor initialises the text editor, adjusting the controls
        /// depending on the account type provided.
        /// </summary>
        /// <param name="parent">This forms parent, typically login</param>
        /// <param name="account">The currently logged in account</param>
        public TextEditor(Form parent, Account account)
        {
            InitializeComponent();

            // Set private variables based from parameters
            this.parent = parent;
            this.account = account;

            // Update labels & controls absed on logged in account
            loggedInLabel.Text = "User Name: " + account.username.ToString();
            fontComboBox.Text = textBox.Font.Size.ToString();
            if (account.accountType == AccountType.View)
            {
                UpdateElementStatus(false);
            }
            else
            {
                UpdateElementStatus(true);
            };
        }

        /// <summary>
        /// This function disabled & enabled the relevant controls based on the canEdit parameter
        /// </summary>
        /// <param name="canEdit">Should the editing controls be enabled</param>
        void UpdateElementStatus(bool canEdit)
        {
            textBox.ReadOnly = !canEdit;
            boldButton.Enabled = canEdit;
            italicButton.Enabled = canEdit;
            underlineButton.Enabled = canEdit;
            pasteButton.Enabled = canEdit;
            pasteItem.Enabled = canEdit;
            cutButton.Enabled = canEdit;
            cutItem.Enabled = canEdit;
            saveAsButton.Enabled = canEdit;
            saveAsItem.Enabled = canEdit;
            saveFileButton.Enabled = canEdit;
            saveFileItem.Enabled = canEdit;
            newFileButton.Enabled = canEdit;
            newFileItem.Enabled = canEdit;
            fontComboBox.Enabled = canEdit;
        }

        /// <summary>
        /// NewFile clears the current text box & removes any references to previously opened files, therefore
        /// requiring a new file to be saved regardless of which button is pressed the first time
        /// </summary>
        void NewFile(object sender, EventArgs e)
        {
            textBox.Text = "";
            currentFile = "";
        }


        /// <summary>
        /// Save will call the save as function if we are in a document that hasn't been saved before. Otherwise
        /// it looks up the file's path & overwrites its content based on the text boxes new content
        /// </summary>
        void Save(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                SaveAs(sender, e);
            }
            else
            {
                // Get the path of the file that was opened last & make sure it has the .rtf extension not .txt
                string newFilePath = Path.Combine(Path.GetDirectoryName(currentFile), Path.GetFileNameWithoutExtension(currentFile) + ".rtf");
                textBox.SaveFile(newFilePath);
            }
        }


        /// <summary>
        /// Save As opens the save file dialog with a starting directory & file name if required
        /// </summary>
        void SaveAs(object sender, EventArgs e)
        {
            if (currentFile != "")
            {
                // We can start the dialog in the last place a file was saved for convenience
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(currentFile);
                saveFileDialog.FileName = Path.GetFileName(currentFile);
            }

            // Open the dialog
            saveFileDialog.ShowDialog();
        }


        /// <summary>
        /// This function is triggered when the save file dialog is closed. When closed, it saves
        /// the contents of the textbox to the dialogs selected path.
        /// </summary>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox.SaveFile(saveFileDialog.FileName);
            currentFile = saveFileDialog.FileName;
        }


        /// <summary>
        /// OpenFile is used to show the open file dialog in order to select a file to load into
        /// the text editor.
        /// </summary>
        private void OpenFile(object sender, EventArgs e)
        {
            // Open the file dialog & check it wasn't cancelled
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Check a valid file/path was picked
                string fileName = openFileDialog.FileName;
                if (fileName != "")
                {
                    // Load the file into the rich text box based on its extension
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
        }


        /// <summary>
        /// Cut is called when the cut buttons are pressed. It performs the cut action on the rich text box
        /// </summary>
        private void Cut(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        /// <summary>
        /// Paste is called when the cut buttons are pressed. It performs the paste action on the rich text box
        /// </summary>
        private void Paste(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        /// <summary>
        /// Copy is called when the cut buttons are pressed. It performs the copy action on the rich text box
        /// </summary>
        private void Copy(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        /// <summary>
        /// This function is called when the bold button is pressed. It toggles the current fonts bold styles.
        /// </summary>
        private void boldButton_Click(object sender, EventArgs e)
        {
            // Get the font of the current selection, if thats null, then fallback to the files font
            Font f = textBox.SelectionFont ?? textBox.Font;
            updateStyle(!f.Bold, f.Italic, f.Underline);
        }

        /// <summary>
        /// This function is called when the italic button is pressed. It toggles the current fonts italic styles.
        /// </summary>
        private void italicButton_Click(object sender, EventArgs e)
        {
            // Get the font of the current selection, if thats null, then fallback to the files font
            Font f = textBox.SelectionFont ?? textBox.Font;
            updateStyle(f.Bold, !f.Italic, f.Underline);
        }

        /// <summary>
        /// This function is called when the underline button is pressed. It toggles the current fonts underline styles.
        /// </summary>
        private void underlineButton_Click(object sender, EventArgs e)
        {
            // Get the font of the current selection, if thats null, then fallback to the files font
            Font f = textBox.SelectionFont ?? textBox.Font;
            updateStyle(f.Bold, f.Italic, !f.Underline);
        }

        /// <summary>
        /// UpdateStyle takes in three font style parameters, constructs a font based on them & sets
        /// the rich text boxes selection font accordingly.
        /// </summary>
        /// <param name="bold">Whether bold font styles are enabled</param>
        /// <param name="italic">Whether italic font styles are enabled</param>
        /// <param name="underline">Whether underline font styles are enabled</param>
        private void updateStyle(bool bold, bool italic, bool underline)
        {
            // Start off with a plain font & then add the additional styles if required
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
            // Set the textboxes selection font to the newly generated one
            textBox.SelectionFont = new Font(textBox.SelectionFont ?? textBox.Font, style);
            textBox.Focus();
        }

        /// <summary>
        /// This function is called when the logout button is pressed. It hides the current component &
        /// shows the parent, in this case, the login form.
        /// </summary>
        private void logoutItem_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        /// <summary>
        /// This function is called when the text boxes selection is changed. It sets the new/updated font size
        /// if it has changed recently.
        /// </summary>
        private void textBox_SelectionChanged(object sender, EventArgs e)
        {
            // If the combo box was recently changed, update the font
            if (newSizeFont != null)
            {
                textBox.SelectionFont = newSizeFont;
                newSizeFont = null;
            }
        }

        /// <summary>
        /// This function is called when the font combo box is typed in. It is used to restrict
        /// the possible input characters to just numeric digits & control characters, e.g. backspaces.
        /// </summary>
        private void fontComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// This function is called when the the font combo boxes value is updated. It generates
        /// a font with the new size & updates the rich text boxes current selection accordingly.
        /// </summary>
        private void FontSizeChanged()
        {
            try
            {
                // Get the font of the current selection, if thats null, then fallback to the files font
                Font currentfont = textBox.SelectionFont ?? textBox.Font;
                // By setting newSizeFont, the next time the rich text box is selected, the size will be applied again.
                // This is to prevent an issue where upon refocusing the text box, the size isn't updated.
                newSizeFont = new Font(currentfont.FontFamily, float.Parse(fontComboBox.Text.ToString()), currentfont.Style);
                textBox.SelectionFont = newSizeFont;
            }
            catch
            {
                Console.WriteLine("Invalid value entered in combo box");
            }
        }

        /// <summary>
        /// This function is called when the the font combo boxes value is updated. It generates
        /// a font with the new size & updates the rich text boxes current selection accordingly.
        /// </summary>
        private void fontComboBox_TextUpdate(object sender, EventArgs e)
        {
            FontSizeChanged();
        }

        /// <summary>
        /// This function is called when the the font combo boxes value is updated. It generates
        /// a font with the new size & updates the rich text boxes current selection accordingly.
        /// </summary>
        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontSizeChanged();
        }

        /// <summary>
        /// This function is called when the about button is pressed. It opens the about form
        /// on top of this one.
        /// </summary>
        private void aboutItem_Click(object sender, EventArgs e)
        {
            Form f = new AboutForm(account);
            f.ShowDialog();
            f.TopMost = true;
        }

        /// <summary>
        /// This function is called when the 'x' is pressed. In that case, close the parent as well so the application
        /// doesn't stay running in the background.
        /// </summary>
        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();
        }
    }
}
