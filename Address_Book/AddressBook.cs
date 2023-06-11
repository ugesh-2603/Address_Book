using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class AddressBook
    {
        public List<Contacts> Contacts { get; set; } // Declaration of a public property named "Contacts" of type List<Contacts>.
                                                     // This property will be used to store a collection of contacts.

        public AddressBook()  // Constructor for the AddressBook class.
        {
            Contacts = new List<Contacts>(); // Initializes the "Contacts" property as a new instance of List<Contacts>.
        }

        public void AddContact(Contacts contact) // Method for adding a contact to the address book.
                                                // Takes a parameter named "contact" of type Contacts, representing the contact to be added.
        {
            Contacts.Add(contact);   // Adds the specified contact to the "Contacts" list.
        } 
    }
}
