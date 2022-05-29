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
        public string Email = ("^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}");
        public void ValidateEmailId(string Email_Id)
        {
            Regex regex = new Regex(Email);
            if (regex.IsMatch(Email_Id))
            {
                Console.WriteLine("Email is Valid :" + Email_Id);
            }
            else
            {
                Console.WriteLine("Email is invalid");
            }
        }
    }
}
