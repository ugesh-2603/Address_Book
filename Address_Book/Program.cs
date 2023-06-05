namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Problem ");

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Present_Address: ");
            string Present_address = Console.ReadLine();

            Console.Write("Enter Premanent_Address: ");
            string Permanent_address = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zip Code: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Contacts contact = new Contacts(firstName, lastName, Present_address, Permanent_address , city, state, zip, phoneNumber, email);

            Console.WriteLine($"Created contact: {contact.FirstName} {contact.LastName}");
        }
    }
}