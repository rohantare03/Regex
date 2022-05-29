namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the Mobile Number");
            string MobileNumber = Console.ReadLine();
            userRegistration.ValidateMobileNum(MobileNumber);

        }
    }
}