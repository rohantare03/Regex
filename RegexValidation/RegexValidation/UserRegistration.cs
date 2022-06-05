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
        public string ValidFirstName(string firstName)
        {
            Regex regex = new Regex(FirstName);
            bool UserFirstName(string UserFirstName) => regex.IsMatch(firstName);
            bool result = UserFirstName(firstName);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The firstname is valid: " + firstName);
                    return "FirstName is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.FIRSTNAME_INVALID, "FirstName is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.FIRSTNAME_INVALID, "FirstName is invalid");
            }
        }
        public string ValidLastName(string lastName)
        {
            Regex regex = new Regex(LastName);
            bool UserLastName(string UserLastName) => regex.IsMatch(lastName);
            bool result = UserLastName(lastName);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The lastname is valid: " + lastName);
                    return "LastName is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.LASTNAME_INVALID, "LastName is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.LASTNAME_INVALID, "LastName is invalid");
            }
        }
        public string ValidEmail(string email)
        {
            Regex regex = new Regex(Email);
            bool UserEmail(string UserEmail) => regex.IsMatch(email);
            bool result = UserEmail(email);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The EmailId is valid: " + email);
                    return "EmailId is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "EmailId is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "EmailId is invalid");
            }
        }
        public string ValidMobile(string mobile_Num)
        {
            Regex regex = new Regex(MobileNum);
            bool UserMobile(string UserMobile) => regex.IsMatch(mobile_Num);
            bool result = UserMobile(mobile_Num);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The Mobile Number is valid: " + mobile_Num);
                    return "Mobile Number is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.MOBILE_INVALID, "Mobile Number is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.MOBILE_INVALID, "Mobile Number is invalid");
            }
        }
        public string ValidPassword(string passWord)
        {
            Regex regex = new Regex(PassWord1);
            bool UserPassword(string UserPassword) => regex.IsMatch(passWord);
            bool result = UserPassword(passWord);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The Password is valid: " + passWord);
                    return "Password is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
        public string ValidPassword2(string passWord2)
        {
            Regex regex = new Regex(PassWord2);
            bool UserPassword2(string UserPassword2) => regex.IsMatch(passWord2);
            bool result = UserPassword2(passWord2);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The Password is valid: " + passWord2);
                    return "Password is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
        public string ValidPassword3(string passWord3)
        {
            Regex regex = new Regex(PassWord3);
            bool UserPassword3(string UserPassword3) => regex.IsMatch(passWord3);
            bool result = UserPassword3(passWord3);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The Password is valid: " + passWord3);
                    return "Password is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
        public string ValidPassword4(string passWord4)
        {
            Regex regex = new Regex(PassWord4);
            bool UserPassword4(string UserPassword4) => regex.IsMatch(passWord4);
            bool result = UserPassword4(passWord4);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The Password is valid: " + passWord4);
                    return "Password is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password is invalid");
            }
        }
        public string ValidAllEmails(string Emails)
        {
            Regex regex = new Regex(AllEmails);
            bool UserAllEmails(string UserAllEmails) => regex.IsMatch(Emails);
            bool result = UserAllEmails(Emails);
            try
            {
                if (result == true)
                {
                    Console.WriteLine("The Email is valid: " + (Emails));
                    return "Email is valid";
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "Email is invalid");
                }

            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "Email is invalid");
            }
        }
    }
}
