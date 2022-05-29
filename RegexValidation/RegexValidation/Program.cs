namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the Password");
            string Pass_Word = Console.ReadLine();
            userRegistration.ValidatePassWord4(Pass_Word); 

        }
    }
}