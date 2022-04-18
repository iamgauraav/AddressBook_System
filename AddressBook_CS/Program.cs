using System;

namespace AddressBook_CS
{
    class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string email;
        public long phoneNumber;

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string email, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.email = email;
            this.phoneNumber = phoneNumber;
            
        }

        static void Main(string[] args)
        {
            Contacts contacts = new Contacts("Gaurav", "Rawat", "Indore", "Indore", "M.P", "452001", "hhhghggg@gmail.com", 9434349222 );
        }     
    }
}
