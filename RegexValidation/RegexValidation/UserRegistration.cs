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
        public string First_Name(string firstName)
        {
            try
            {
                Regex regex = new Regex(FirstName);
                if (regex.IsMatch(firstName))
                {
                    Console.WriteLine("Firstname is valid :" + firstName);
                    return firstName;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.FIRSTNAME_INVALID, "First Name should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.FIRSTNAME_INVALID, "First Name should not be invalid");
            }
        }
        public string Last_Name(string lastName)
        {
            try
            {
                Regex regex = new Regex(LastName);
                if (regex.IsMatch(lastName))
                {
                    Console.WriteLine("Lastname is valid :" + lastName);
                    return lastName;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.LASTNAME_INVALID, "Last Name should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.LASTNAME_INVALID, "Last Name should not be invalid");
            }
        }
        public string EmailId(string Email_Id)
        {
            try
            {
                Regex regex = new Regex(Email);
                if (regex.IsMatch(Email_Id))
                {
                    Console.WriteLine("EmailId is valid :" + Email_Id);
                    return Email_Id;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "Email should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "Email should not be invalid");
            }
        }
        public string Mobile(string Mobile_Num)
        {
            try
            {
                Regex regex = new Regex(MobileNum);
                if (regex.IsMatch(Mobile_Num))
                {
                    Console.WriteLine("Mobile Number is valid :" + Mobile_Num);
                    return Mobile_Num;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.MOBILE_INVALID, "Mobile Number should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.MOBILE_INVALID, "Mobile Number should not be invalid");
            }
        }
        public string Validate_PassWord(string passWord)
        {
            try
            {
                Regex regex = new Regex(PassWord1);
                if (regex.IsMatch(passWord))
                {
                    Console.WriteLine("Password is valid :" + passWord);
                    return passWord;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
            }
        }
        public string Validate_PassWord2(string passWord2)
        {
            try
            {
                Regex regex = new Regex(PassWord2);
                if (regex.IsMatch(passWord2))
                {
                    Console.WriteLine("Password is valid :" + passWord2);
                    return passWord2;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
            }
        }
        public string Validate_PassWord3(string passWord3)
        {
            try
            {
                Regex regex = new Regex(PassWord3);
                if (regex.IsMatch(passWord3))
                {
                    Console.WriteLine("Password is valid :" + passWord3);
                    return passWord3;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
            }
        }
        public string Validate_PassWord4(string passWord4)
        {
            try
            {
                Regex regex = new Regex(PassWord4);
                if (regex.IsMatch(passWord4))
                {
                    Console.WriteLine("Password is valid :" + passWord4);
                    return passWord4;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.PASSWORD_INVALID, "Password should not be invalid");
            }
        }
        public string Validate_AllEmails(string All_Email)
        {
            try
            {
                Regex regex = new Regex(AllEmails);
                if (regex.IsMatch(All_Email))
                {
                    Console.WriteLine("Password is valid :" + All_Email);
                    return All_Email;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "Email should not be invalid");
                }
            }
            catch
            {
                throw new RegexCustomException(RegexCustomException.Exceptiontype.EMAILID_INVALID, "Email should not be invalid");
            }
        }
    }
}
