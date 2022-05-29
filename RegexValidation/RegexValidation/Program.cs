namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the EmailId");
            string EmailId = Console.ReadLine();
            userRegistration.ValidateEmailId(EmailId);

        }
    }
}