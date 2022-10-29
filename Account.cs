using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevDotNetTask2
{
    /// <summary>
    /// AccountType is an enum that can be two possible values, View or Edit
    /// </summary>
    public enum AccountType
    {
        View, Edit
    }

    /// <summary>
    /// Account is a struct that represents a line in the login.txt file
    /// </summary>
    public struct Account
    {
        public readonly string username;
        public readonly string password;
        public readonly AccountType accountType;
        public readonly string firstName;
        public readonly string lastName;
        public readonly DateTime dob;

        public Account(string username, string password, AccountType accountType, string firstName, string lastName, DateTime dob)
        {
            this.username = username;
            this.password = password;
            this.accountType = accountType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
        }
    }
}
