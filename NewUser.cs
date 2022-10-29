using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppDevDotNetTask2
{
    public partial class NewUser : Form
    {
        // The parent of this form
        private Form parent;

        /// <summary>
        /// This constructor just takes in the parent of this form & stores it in the local variable
        /// </summary>
        /// <param name="parent">The parent of this form</param>
        public NewUser(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        /// <summary>
        /// This function is called when the cancel button is pressed. It hides the current form & shows the
        /// parent, which is always the login form.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
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
        /// ValidateValue is used to confirm a given value meets a set of criteria involving minimum length &
        /// whether it contains spaces
        /// </summary>
        /// <param name="labelName">The value/label/field name to print in any error messages</param>
        /// <param name="value">The value to check</param>
        /// <param name="minLength">Minimum length the value should be</param>
        /// <returns>Whether the given value was valid</returns>
        private bool ValidateValue(string labelName, string value, int minLength)
        {
            // Check the value meets the minimum length, if not, error accordingly
            if (value.Length < minLength)
            {
                MessageBox.Show(labelName + " needs to be at least " + minLength + " characters, please change the value.", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check the value doesn't contain spaces, if not, error accordingly
            if (value.Contains(" "))
            {
                MessageBox.Show(labelName + " can only be a single word. Please remove any spaces", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// This function is called when the submit button is pressed. It validates all of the input fields
        /// and creates an account if everything is valid.
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Get a list of the accounts in login.txt
            List<Account> accounts = FileManager.GetAccounts();
            // Check if the inputted username is taken
            int accountIndex = accounts.FindIndex(acc => acc.username == usernameInput.Text);
            // If the username isn't taken then validate the other fields
            if (accountIndex == -1)
            {
                if (accountComboBox.Text == "")
                {
                    MessageBox.Show("Please select a valid account type.", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (passwordInput.Text != confirmPasswordInput.Text)
                {
                    MessageBox.Show("Your passwords do not match.", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (dateOfBirthPicker.Value >= DateTime.Now)
                {
                    MessageBox.Show("Your date of birth cannot be in the future", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use the validatevalue function to easily validate 4 fields at once
                if (ValidateValue("Username", usernameInput.Text, 2) &&
                    ValidateValue("Password", passwordInput.Text, 2) &&
                    ValidateValue("First Name", firstNameInput.Text, 2) &&
                    ValidateValue("Last Name", lastNameInput.Text, 2))
                {
                    // Create the account & error if it failed.
                    bool success = FileManager.AddNewAccount(new Account(
                        usernameInput.Text,
                        passwordInput.Text,
                        (AccountType)Enum.Parse(typeof(AccountType), accountComboBox.Text),
                        firstNameInput.Text,
                        lastNameInput.Text,
                        dateOfBirthPicker.Value));

                    // If the account was created successfully, send a message & hide this form in favour of the login menu.
                    if (success)
                    {
                        MessageBox.Show("Succesfully created new account!", "Created new account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        parent.Show();
                        return;
                    }

                    MessageBox.Show("Failed to create new account. Error reading file.", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // The username is taken, error accordingly
                MessageBox.Show("An account already exists with that username. Please use a different one.", "Failed to create new account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This function is called when the 'x' button is pressed. In this case, show the login form.
        /// </summary>
        private void NewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            parent.Show();
        }
    }
}
