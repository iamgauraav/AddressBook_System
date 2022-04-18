using System;
using System.Collections.Generic;
namespace AddressBook_CS
{
    public class AddressBook
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
            personDetails.Add(person);
        }
        /// <summary>
        /// Method for Printing the address book details
        /// </summary>
        /// <param name="args"></param>
        public void Print()
        {
            foreach (Contact person in personDetails)
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
  
        }
        /// <summary>
        /// Method for Editing the contacts
        /// </summary>
        public void Edit()
        {
            if (personDetails.Count != 0)
            {
                Console.WriteLine("Enter contact to modify");
                string edit = Console.ReadLine();
                foreach (var person in personDetails)
                {
                    if (person.firstName.ToUpper() == edit.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property:");
                            Console.WriteLine("Enter 1 to change First name");
                            Console.WriteLine("Enter 2 to change Last name");
                            Console.WriteLine("Enter 3 to change Phone number");
                            Console.WriteLine("Enter 4 to change address ");
                            Console.WriteLine("Enter 5 to change City");
                            Console.WriteLine("Enter 6 to change State");
                            Console.WriteLine("Enter 7 to change Pincode");
                            Console.WriteLine("Enter 8 to exit");
                            int Option = Convert.ToInt32(Console.ReadLine());
                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Last name");
                                    person.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Phone Number");
                                    person.phoneNumber = int.Parse(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address");
                                    person.address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City");
                                    person.city = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pincode ");
                                    person.zip = Console.ReadLine();
                                    break;
                                case 8:
                                    return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name..!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty..!");
            }
        } 
    }
}
