using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation
{
    public class UserRegistration
    {
        public string FirstName = ("^[A-Z]{1}[A-Za-z]{2,}$");
        public string LastName = ("^[A-Z]{1}[A-Za-z]{2,}$"); 

        public string Validate_FirstName(string firstName)
        {
            Regex regex = new Regex(FirstName);
            if (regex.IsMatch(firstName))
            {
                Console.WriteLine("First Name is Valid :" + firstName);
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
            return firstName;
        }
        public string Last_Name(string lastName)
        {
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(lastName))
            {
                Console.WriteLine("Last Name is Valid :" + lastName);
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
            return lastName;
        }
    }
}
