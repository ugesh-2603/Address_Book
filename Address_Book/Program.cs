namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Problem ");

            AddressBook addressBook = new AddressBook();

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

            addressBook.AddContact(contact);

            Console.WriteLine($"Created contact: {contact.FirstName} {contact.LastName}");

            Console.WriteLine("Do you want to edit a contact? (yes/no)");
            string editInput = Console.ReadLine();

            if (editInput.ToLower() == "yes")
            {
                Console.Write("Enter First Name of contact to edit: ");
                string firstNameToEdit = Console.ReadLine();

                Console.Write("Enter Last Name of contact to edit: ");
                string lastNameToEdit = Console.ReadLine();

                Console.WriteLine("Enter new contact details:");

                Console.Write("Enter First Name: ");
                 firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                 lastName = Console.ReadLine();

                Console.Write("Enter Present_Address: ");
                 Present_address = Console.ReadLine();

                Console.Write("Enter Premanent_Address: ");
                 Permanent_address = Console.ReadLine();

                Console.Write("Enter City: ");
                 city = Console.ReadLine();

                Console.Write("Enter State: ");
                 state = Console.ReadLine();

                Console.Write("Enter Zip Code: ");
                 zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                 phoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                 email = Console.ReadLine();

                Contacts newcontact = new Contacts(firstName, lastName, Present_address, Permanent_address, city, state, zip, phoneNumber, email);

                addressBook.EditContact(firstNameToEdit, lastNameToEdit, newcontact);

                Console.WriteLine($"Edited contact: {newcontact.FirstName} {newcontact.LastName}");
            }

            Console.WriteLine("Do you want to delete a contact? (yes/no)");
            string deleteInput = Console.ReadLine();

            if (deleteInput.ToLower() == "yes")
            {
                Console.Write("Enter First Name of contact to delete: ");
                string firstNameToDelete = Console.ReadLine();

                Console.Write("Enter Last Name of contact to delete: ");
                string lastNameToDelete = Console.ReadLine();

                addressBook.DeleteContact(firstNameToDelete, lastNameToDelete);
            }
        }
    }
}