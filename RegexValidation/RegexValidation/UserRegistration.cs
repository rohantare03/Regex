﻿using System;
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
        public string Validate_LastName(string lastName)
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
        public string Validate_EmailId(string Email_Id)
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
        public string Validate_Mobile(string Mobile_Num)
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
        public string Validate_PassWord(string passWord)
        {
            Regex regex = new Regex(PassWord1);
            if (regex.IsMatch(passWord))
            {
                Console.WriteLine("Password is valid :" + passWord);
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
            return passWord;
        }
        public string Validate_PassWord2(string passWord2)
        {
            Regex regex = new Regex(PassWord2);
            if (regex.IsMatch(passWord2))
            {
                Console.WriteLine("Password is valid :" + passWord2);
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
            return passWord2;
        }
        public string Validate_PassWord3(string passWord3)
        {
            Regex regex = new Regex(PassWord3);
            if (regex.IsMatch(passWord3))
            {
                Console.WriteLine("Password is valid :" + passWord3);
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
            return passWord3;
        }
        public string Validate_PassWord4(string passWord4)
        {
            Regex regex = new Regex(PassWord4);
            if (regex.IsMatch(passWord4))
            {
                Console.WriteLine("Password is valid :" + passWord4);
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
            return passWord4;
        }
        public string Validate_AllEmails(string All_Email)
        {
            Regex regex = new Regex(AllEmails);
            if (regex.IsMatch(All_Email))
            {
                Console.WriteLine("Email is Valid : " + All_Email);
            }
            else
            {
                Console.WriteLine("Email is invalid");
            }
            return All_Email;
        }
    }
}
