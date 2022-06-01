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
        public string PassWord1 = ("^[A-Za-z0-9@#$%^&*+]{8,}$");
        public string PassWord2 = ("^[A-Z]{1,}[A-Za-z0-9@#$%^&*+]{7,}$");
        public string PassWord3 = ("^[A-Z]{1,}[A-Za-z0-9@#$%^&*+]{6,}[0-9]{1,}$");
        public string PassWord4 = ("^[A-Z]{1,}[A-Za-z0-9]{5,}[@#$%^&*+]{1}[0-9]{1,}$");
        public string AllEmails = ("^[A-Za-z0-9]+([.+_-]?[A-Za-z0-9])*@[A-Za-z0-9]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$");

        public string Validate_FirstName(string firstName)
        {
            try
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
            catch (NullReferenceException)
            {
                throw new RegexValidationCustomException(RegexValidationCustomException.Exceptiontype.FIRSTNAME_INVALID, "First name should not be invalid");
            }
        }
        public string Validate_LastName(string lastName) 
        {
            try
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
            catch (NullReferenceException)
            {
                throw new RegexValidationCustomException(RegexValidationCustomException.Exceptiontype.LASTNAME_INVALID, "Last name should not be invalid");
            }
        }
    }
}
