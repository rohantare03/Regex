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
        }
    }
}