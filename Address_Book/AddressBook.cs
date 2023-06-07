using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class AddressBook
    {
        public List<Contacts> Contacts { get; set; }

        public AddressBook()
        {
            Contacts = new List<Contacts>();
        }

        public void AddContact(Contacts contact)
        {
            Contacts.Add(contact);
        }

        public void EditContact(string firstName, string lastName, Contacts newContactDetails)
        {
            Contacts contactToUpdate = Contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);

            if (contactToUpdate != null)
            {
                int index = Contacts.IndexOf(contactToUpdate);
                Contacts[index] = newContactDetails;
            }
            else
            {
                Console.WriteLine($"Contact with name {firstName} {lastName} not found.");
            }
        }
    }
}
