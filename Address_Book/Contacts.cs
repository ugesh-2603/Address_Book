using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Present_Address { get; set; }

        public string Permanent_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contacts(string firstName, string lastName, string Present_address, string Permanent_address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Present_Address = Present_address;
            Permanent_Address = Permanent_address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;

        }
    }
}
