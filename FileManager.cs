using System;
using System.Collections.Generic;
using System.IO;

namespace AppDevDotNetTask2
{
    class FileManager
    {
        /// <summary>
        /// Get Accounts opens & reads the login.txt file into an array of Accounts. It then returns this array.
        /// </summary>
        /// <returns>A list of accounts from the file</returns>
        public static List<Account> GetAccounts()
        {
            // Create an empty list
            List<Account> accounts = new List<Account>();
            try
            {
                // Read each line in the file & loop through them
                string[] lines = File.ReadAllLines("login.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    // Split each field on the line by the comma delimiter
                    string[] fields = lines[i].Split(',');
                    // Confirm the line has the correct amount of fields before creating the account object
                    if (fields.Length != 6)
                    {
                        Console.WriteLine("Failed to read credential line " + i);
                        continue;
                    }

                    // Create a new account object & add it to the list with the relevant fields from the line
                    accounts.Add(new Account(
                        fields[0],
                        fields[1],
                        (AccountType)Enum.Parse(typeof(AccountType), fields[2]),
                        fields[3],
                        fields[4],
                        DateTime.Parse(fields[5])
                        ));
                }

            }
            catch
            {
                Console.WriteLine("Failed to read login file");
            }
            return accounts;
        }

        /// <summary>
        /// AddNewAccount takes in an account & adds it to the end of the login.txt file
        /// </summary>
        /// <param name="account">The account to add to the file</param>
        /// <returns>Whether it was successfull</returns>
        public static bool AddNewAccount(Account account)
        {
            try
            {
                // Open the file in append mode
                using (StreamWriter loginStreamWriter = File.AppendText("login.txt"))
                {
                    // Write the details of the account to the file on a new line
                    loginStreamWriter.Write(string.Format("\n{0},{1},{2},{3},{4},{5}",
                        account.username,
                        account.password,
                        account.accountType,
                        account.firstName,
                        account.lastName,
                        account.dob.ToString("dd-MM-yyyy")));
                }
            }
            catch (Exception e)
            {
                // Error if something went wrong
                Console.WriteLine("Failed to add new account " + e.ToString());
                return false;
            }

            return true;
        }
    }
}
