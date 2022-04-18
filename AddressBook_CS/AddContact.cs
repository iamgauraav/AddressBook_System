using System;
using System.Collections.Generic;
namespace AddressBook_CS
{
    public class AddContact
    {
        List<Contact> personDetails = new List<Contact>();

        //creating a method for adding contacts in addressbook
        public void AddPerson()
        {
            //creating object for contact class
            Contact person = new Contact();
            Console.WriteLine("Enter First name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address name");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter city name");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state name");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter email");
            person.email = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            person.phoneNumber = long.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Method for Printing the address book details
        /// </summary>
        /// <param name="args"></param>
        private void Print(Contact person)
        {
            Console.WriteLine("-------Address book details-------");
            Console.WriteLine("First Name:" + person.firstName);
            Console.WriteLine("Last Name:" + person.lastName);
            Console.WriteLine("Address:" + person.address);
            Console.WriteLine("City:" + person.city);
            Console.WriteLine("State:" + person.state);
            Console.WriteLine("Zip:" + person.zip);
            Console.WriteLine("Email:" + person.email);
            Console.WriteLine("Phone Number:" + person.phoneNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome to Address Book-----");
            //creating object person1 of Addcontact Class()
            AddContact person1 = new AddContact();
            person1.AddPerson();
        }
    }
}
