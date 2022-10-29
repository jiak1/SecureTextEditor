namespace AppDevDotNetTask2
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.MaskedTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.MaskedTextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordInput = new System.Windows.Forms.MaskedTextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.MaskedTextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.MaskedTextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(33, 295);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(380, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(33, 266);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(380, 23);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(104, 25);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(200, 26);
            this.welcomeLabel.TabIndex = 12;
            this.welcomeLabel.Text = "Create A New User";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(29, 97);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 20);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(194, 97);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(219, 20);
            this.passwordInput.TabIndex = 10;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(29, 71);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(87, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(194, 73);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(219, 20);
            this.usernameInput.TabIndex = 8;
            this.usernameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(29, 123);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(141, 20);
            this.confirmPasswordLabel.TabIndex = 17;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Location = new System.Drawing.Point(194, 123);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.PasswordChar = '*';
            this.confirmPasswordInput.Size = new System.Drawing.Size(219, 20);
            this.confirmPasswordInput.TabIndex = 11;
            this.confirmPasswordInput.UseSystemPasswordChar = true;
            this.confirmPasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(29, 149);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(194, 149);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(219, 20);
            this.firstNameInput.TabIndex = 12;
            this.firstNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(29, 175);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(194, 175);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(219, 20);
            this.lastNameInput.TabIndex = 13;
            this.lastNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(29, 201);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(106, 20);
            this.dateOfBirthLabel.TabIndex = 22;
            this.dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(194, 201);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(219, 20);
            this.dateOfBirthPicker.TabIndex = 14;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.AutoSize = true;
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.Location = new System.Drawing.Point(29, 225);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(85, 20);
            this.userTypeLabel.TabIndex = 24;
            this.userTypeLabel.Text = "User Type:";
            // 
            // accountComboBox
            // 
            this.accountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.accountComboBox.Location = new System.Drawing.Point(194, 227);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(219, 21);
            this.accountComboBox.TabIndex = 15;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 339);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUser";
            this.Text = "New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUser_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.MaskedTextBox passwordInput;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.MaskedTextBox usernameInput;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.MaskedTextBox confirmPasswordInput;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox firstNameInput;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.MaskedTextBox lastNameInput;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.ComboBox accountComboBox;
    }
}