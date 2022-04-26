using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook_CS
{
    class AddressBookMain
    {
        class AddContact
        {   //Uc2 to create contact in an address book
            public List<Contact> personDetails = new List<Contact>();

            //Creating a method for adding contacts in adrressbook
            private void AddPerson()
            {
                //creating object person from Contact class
                Contact person = new Contact();
                Console.WriteLine("Enter first name");
                person.firstName = Console.ReadLine();
                Console.WriteLine("Enter last name");
                person.lastName = Console.ReadLine();
                Console.WriteLine("Enter address name");
                person.address = Console.ReadLine();
                Console.WriteLine("Enter city name");
                person.city = Console.ReadLine();
                Console.WriteLine("Enter state name");
                person.state = Console.ReadLine();
                Console.WriteLine("Enter zip name");
                person.zip = Console.ReadLine();
                Console.WriteLine("Enter phone number");
                person.phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter email id");
                person.email = Console.ReadLine();
                personDetails.Add(person);
                Print(person);
            }

            //Printing the address book details 
            private void Print(Contact person)
            {
                Console.WriteLine("---Address book details----");
                Console.WriteLine("First Name:" + person.firstName);
                Console.WriteLine("Last Name:" + person.lastName);
                Console.WriteLine("Address:" + person.address);
                Console.WriteLine("City:" + person.city);
                Console.WriteLine("State:" + person.state);
                Console.WriteLine("Zip:" + person.zip);
                Console.WriteLine("Phone Number:" + person.phoneNumber);
                Console.WriteLine("Email:" + person.email);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("---Welcome to your Address Book--");
                //creating object person1 of Addcontact Class()
                AddContact person1 = new AddContact();
                person1.AddPerson();
                Console.ReadLine();

            }
        }
    }
}
