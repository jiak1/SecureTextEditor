using System;
using System.Windows.Forms;

namespace AppDevDotNetTask2
{
    public partial class AboutForm : Form
    {
        /// <summary>
        /// This constructor takes in the logged in account & updates the values of its labels accordingly
        /// </summary>
        /// <param name="account">The current logged in account</param>
        public AboutForm(Account account)
        {
            InitializeComponent();
            accountLabel.Text = String.Format("Username: {0}\nFirst Name: {1}\nLast Name: {2}\nAccount Type: {3}\nDate Of Birth: {4}",
                account.username,
                account.firstName,
                account.lastName,
                account.accountType,
                account.dob.ToShortDateString());
        }
    }
}
