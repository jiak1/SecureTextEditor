using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppDevDotNetTask2
{
    public partial class Login : Form
    {
        /// <summary>
        /// This constructor just initialises the form.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function is called when the exit button is pressed. It shuts down the whole application.
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This function is called when the new user button is pressed. It opens up the new user form &
        /// hides the login one.
        /// </summary>
        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUser form = new NewUser(this);
            form.Show();
            Hide();
        }

        /// <summary>
        /// This function is called when the a text box is typed in. It is used to restrict
        /// the possible input characters to just numeric/alphabetical digits & control characters, e.g. backspaces.
        /// </summary>
        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// This function is called when the login button is pressed. It gets the values of the username &
        /// password, looks up the login.txt file & confirms if the entry is valid. If it is, it shows the texteditor form
        /// otherwise it displays an error.
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Read the login.txt file & get a list of accounts
            List<Account> accounts = FileManager.GetAccounts();
            // Search through the list for an account with the username & password that matches the input from the user
            int accountIndex = accounts.FindIndex(acc => acc.username == usernameInput.Text && acc.password == passwordInput.Text);
            // If the account index was found, create a new text editor form with those account details
            if (accountIndex != -1)
            {
                TextEditor form = new TextEditor(this, accounts[accountIndex]);
                Hide();
                form.Show();
            }
            else
            {
                // The input details were incorrect, let the user know
                MessageBox.Show("An account does not exist with those details. Please try again or create a new account.", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}