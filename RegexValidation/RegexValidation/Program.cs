namespace RegexValidation
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

            //uc3 : Email
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Email Id");
            string email_Id = Console.ReadLine();
            userRegistration.Validate_EmailId(email_Id);

            //uc4 : Mobile Number
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Mobile Number");
            string mobileNum = Console.ReadLine();
            userRegistration.Validate_Mobile(mobileNum);

            //uc5 : Password
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password");
            string Password = Console.ReadLine();
            userRegistration.Validate_PassWord(Password);

            //uc6 : Password minimum one upper case
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one upper case: ");
            string Password2 = Console.ReadLine();
            userRegistration.Validate_PassWord(Password2);

            //uc7 : Password minimum one numeric value
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one numeric value : ");
            string Password3 = Console.ReadLine();
            userRegistration.Validate_PassWord(Password3);


            //uc8 : Password exactly one special character
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one numeric value : ");
            string Password4 = Console.ReadLine();
            userRegistration.Validate_PassWord(Password4);

            //uc9 : AllEmails
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Email");
            string all_Email = Console.ReadLine();
            userRegistration.Validate_AllEmails(all_Email);
        }
    }
}