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
        public string MobileNum = ("^[0-9]{2}[ ][0-9]{10}");
        public void ValidateMobileNum(string Mobile_Num)
        {
            Regex regex = new Regex(MobileNum);
            if (regex.IsMatch(Mobile_Num))
            {
                Console.WriteLine("Mobile Number is Valid :" + Mobile_Num);
            }
            else
            {
                Console.WriteLine("Mobile Number is invalid");
            }
        }
    }
}
