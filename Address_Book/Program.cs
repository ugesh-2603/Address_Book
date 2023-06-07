namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Problem ");

            Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddAddressBook(addressBooks);
                        break;
                    case 2:
                        SelectAddressBook(addressBooks);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        static void AddAddressBook(Dictionary<string, AddressBook> addressBooks)
        {
            Console.Write("Enter a name for the new Address Book: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"An Address Book with the name {name} already exists.");
                return;
            }

            AddressBook newAddressBook = new AddressBook();
            addressBooks[name] = newAddressBook;

            Console.WriteLine($"Added Address Book: {name}");
        }

        static void SelectAddressBook(Dictionary<string, AddressBook> addressBooks)
        {
            Console.WriteLine("Available Address Books:");
            foreach (var name_1 in addressBooks.Keys)
            {
                Console.WriteLine(name_1);
            }

            Console.Write("Enter the name of the Address Book to select: ");
            string name = Console.ReadLine();

            if (!addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"No Address Book found with the name {name}");
                return;
            }

            AddressBook selectedAddressBook = addressBooks[name];

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Show all contacts");
                Console.WriteLine("5. Back");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateContact(selectedAddressBook);
                        break;
                    case 2:
                        EditContact(selectedAddressBook);
                        break;
                    case 3:
                        DeleteContact(selectedAddressBook);
                        break;
                    case 4:
                        ShowAllContacts(selectedAddressBook);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        static void ShowAllContacts(AddressBook addressBook)
        {
            var contacts = addressBook.Contacts;
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts in the address book.");
                return;
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}, Address: {contact.Present_Address}, Address: {contact.Permanent_Address}, City: {contact.City}, State: {contact.State}, Zip: {contact.Zip}, Phone Number: {contact.PhoneNumber}, Email: {contact.Email}");
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
