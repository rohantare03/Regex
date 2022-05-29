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
        public string PassWord = ("^[A-Z]{1,}[A-z0-9a-z@#&*+]{8,}$");
        public void ValidatePassWord2(string passWord) 
        {
            Regex regex = new Regex(PassWord);
            if (regex.IsMatch(passWord))
            {
                Console.WriteLine("PassWord is valid :" + passWord);
            }
            else
            {
                Console.WriteLine("PassWord is invalid");
            }
        }
    }
}
