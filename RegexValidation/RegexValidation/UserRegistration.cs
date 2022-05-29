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
        public string PassWord = "^[A-Z]{1,}[A-Za-z0-9]{5,}[!@#$%^&*+]{1}[0-9]{1,}$";
        public void ValidatePassWord4(string passWord)    
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
