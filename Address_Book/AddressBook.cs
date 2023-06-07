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
    }
}
