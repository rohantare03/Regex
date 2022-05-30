﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation
{
    internal class UserRegistration
    {
        public string FirstName = ("^[A-Z]{1}[A-Za-z]{2,}$");
        public string LastName = ("^[A-Z]{1}[A-Za-z]{2,}$");
        public string Email = ("^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}");
        public string MobileNum = ("^[0-9]{2}[ ][0-9]{10}");
        public string PassWord = ("^[A-Z]{1,}[A-Z0-9a-z]{5,}[@#$%^&*+]{1}[0-9]{1,}$");
        public string AllEmails = ("^[A-Za-z0-9]+([.+_-]?[A-Za-z0-9])*@[A-Za-z0-9]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$");
        public void Validate_FirstName(string firstName)
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
        }
        public void Validate_LastName(string lastName)
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
        }
        public void Validate_EmailId(string Email_Id)
        {
            Regex regex = new Regex(Email);
            if (regex.IsMatch(Email_Id))
            {
                Console.WriteLine("EmailId is Valid :" + Email_Id);
            }
            else
            {
                Console.WriteLine("EmailId is invalid");
            }
        }
        public void Validate_Mobile(string Mobile_Num)
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
        public void Validate_PassWord(string passWord)
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
        public void Validate_AllEmails(string All_Email)
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
        }
    }
}
