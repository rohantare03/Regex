﻿namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            //uc1 : first  name
            Console.WriteLine("Enter the First Name : ");
            string first_Name = Console.ReadLine();
            userRegistration.Validate_FirstName(first_Name);

            //uc2 : last name
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Last Name");
            string last_Name = Console.ReadLine();
            userRegistration.Validate_LastName(last_Name);
        }
    }
}