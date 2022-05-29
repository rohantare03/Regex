namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the Email Ids");
            string email_Ids = Console.ReadLine();
            userRegistration.ValidateAllEmail(email_Ids); 

        }
    }
}