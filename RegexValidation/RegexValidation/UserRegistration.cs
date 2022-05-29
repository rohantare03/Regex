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
        public string Email_Id = ("^[A-Za-z0-9]+([.+_-]?[A-Za-z0-9])*@[A-Za-z0-9]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$");
        public void ValidateAllEmail(string Email)    
        {
            Regex regex = new Regex(Email_Id);
            if (regex.IsMatch(Email))
            {
                Console.WriteLine("PassWord is valid :" + Email);
            }
            else
            {
                Console.WriteLine("PassWord is invalid");
            }
        }
    }
}
