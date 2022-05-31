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
        public string Email = ("^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}$");
        public string MobileNum = ("^[0-9]{2}[ ][0-9]{10}$");

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
        public string EmailId(string Email_Id)
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
            return Email_Id;
        }
        public string Mobile(string Mobile_Num)
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
            return Mobile_Num;
        }
    }
}
