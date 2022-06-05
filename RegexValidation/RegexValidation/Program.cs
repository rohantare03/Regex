namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            //uc1 : first name
            Console.WriteLine("Enter the First Name");
            string firstname = Console.ReadLine();
            userRegistration.ValidFirstName(firstname);


            //uc2 : last name
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Last Name");
            string last_Name = Console.ReadLine();
            userRegistration.ValidLastName(last_Name);

            //uc3 : Email
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Email Id");
            string email_Id = Console.ReadLine();
            userRegistration.ValidEmail(email_Id);

            //uc4 : Mobile
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Mobile Number");
            string mobile_Num = Console.ReadLine();
            userRegistration.ValidMobile(mobile_Num);

            //uc5 : Password
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password");
            string passWord = Console.ReadLine();
            userRegistration.ValidPassword(passWord);

            //uc6 : Password with minimum one upper case
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one upper case");
            string passWord2 = Console.ReadLine();
            userRegistration.ValidPassword2(passWord2);

            //uc7 : Password with minimum one numeric value
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with minimum one numeric value");
            string passWord3 = Console.ReadLine();
            userRegistration.ValidPassword3(passWord3);

            //uc8 : Password with exactly one special character
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Password with exactly one special character");
            string passWord4 = Console.ReadLine();
            userRegistration.ValidPassword4(passWord4);

            //uc9 :All Email Samples
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the Sample Email");
            string Allemail = Console.ReadLine();
            userRegistration.ValidEmail(Allemail);
        }
    }
}