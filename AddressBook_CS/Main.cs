using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook_CS
{
    class AddressBookMain
    {
        public static Dictionary<string, LinkedList<Contact>> addressBook = new Dictionary<string, LinkedList<Contact>>();

        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome to Address Book-----");
            Console.WriteLine("Enter the number of address books want to add;");
            int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
            int noOfBooks = 0;
            
            while (noOfBooks < noOfAddressBook)
            {
                Console.WriteLine("Enter the name of the address book");
                string bookName = Console.ReadLine();
                //creating object person1 of addressbook class
                AddressBook person1 = new AddressBook();
                Console.WriteLine("Enter the number of contacts you want to add in the address book:");
                int contactNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose one operation to perform:\n 1-Add a Contact \n 2-Edit a existing contact \n 3-View Address book contacts \n 4- Delete existing contact \n 5-Exit from the Addressbook");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        while (contactNum > 0)
                        {
                            Console.WriteLine("Enter the details of contact to be added:");
                            person1.AddPerson();
                            contactNum -= 1;
                            person1.Print();
                        }
                        break;
                    case 2:
                        person1.Edit();
                        person1.Print();
                        Console.WriteLine("Enter any key to continue");
                        break;
                    case 3:
                        person1.Delete();
                        person1.Print();
                        Console.WriteLine("Enter any key to continue");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

                if (addressBook.ContainsKey(bookName))
                {
                    Console.WriteLine("Address book is already exists");
                    return;
                }
                else
                {
                    addressBook.Add(bookName, person1.personDetails);
                }
                noOfBooks++;
            }
            foreach (KeyValuePair<string, LinkedList<Contact>> item in addressBook)
            {
                Console.WriteLine("Existing address books are {0}", item.Key);
            }
            
        }
    }
}
