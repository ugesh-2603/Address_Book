namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Problem ");

            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateContact(addressBook);
                        break;
                    case 2:
                        EditContact(addressBook);
                        break;
                    case 3:
                        DeleteContact(addressBook);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        static void CreateContact(AddressBook addressBook)
        {

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

            Contacts contact = new Contacts(firstName, lastName, Present_address, Permanent_address, city, state, zip, phoneNumber, email);
            addressBook.AddContact(contact);

            Console.WriteLine($"Added contact: {contact.FirstName} {contact.LastName}");
        }

        static void EditContact(AddressBook addressBook)
        {
            Console.Write("Enter First Name of contact to edit: ");
            string firstNameToEdit = Console.ReadLine();

            Console.Write("Enter Last Name of contact to edit: ");
            string lastNameToEdit = Console.ReadLine();

            Console.WriteLine("Enter new contact details:");
            CreateContact(addressBook);

            Console.WriteLine($"Edited contact: {firstNameToEdit} {lastNameToEdit}");
        }

        static void DeleteContact(AddressBook addressBook)
        {
            Console.Write("Enter First Name of contact to delete: ");
            string firstNameToDelete = Console.ReadLine();

            Console.Write("Enter Last Name of contact to delete: ");
            string lastNameToDelete = Console.ReadLine();

            addressBook.DeleteContact(firstNameToDelete, lastNameToDelete);

            Console.WriteLine($"Deleted contact: {firstNameToDelete} {lastNameToDelete}");
        }

    }
}
