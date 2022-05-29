namespace RegexValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Regex");
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter the Last Name");
            string Last_Name = Console.ReadLine();
            userRegistration.ValidateLastName(Last_Name);

        }
    }
}