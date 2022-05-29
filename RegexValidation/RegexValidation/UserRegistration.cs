using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation
{
    internal class UserRegistration
    {
        public string LastName = ("^[A-Z]{1}[A-Za-z]{3,}$");
        public void ValidateLastName(string lastName) 
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
        }
    }
}
