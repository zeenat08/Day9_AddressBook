using System;
using System.Collections.Generic;
using System.Text;

namespace DAY9_Address_Book
{
    class UC2_Add_Contacts
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phonenumber;
        public string email;

        public static List<UC2_Add_Contacts> People = new List<UC2_Add_Contacts>();

        public static void NewContact()
        {
            UC2_Add_Contacts person = new UC2_Add_Contacts();

            Console.Write("Enter First Name: ");
            person.firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.lastname = Console.ReadLine();

            Console.Write("Enter the Address: ");
            person.address = Console.ReadLine();

            Console.Write("Enter City name: ");
            person.city = Console.ReadLine();

            Console.Write("Enter State name: ");
            person.state = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            person.zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.phonenumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            person.email = Console.ReadLine();


            People.Add(person);
        }

        public static void Print(UC2_Add_Contacts person)
        {
            Console.WriteLine("First Name: " + person.firstname);
            Console.WriteLine("Last Name: " + person.lastname);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.state);
            Console.WriteLine("Zip Code: " + person.zipcode);
            Console.WriteLine("Phone Number: " + person.phonenumber);
            Console.WriteLine("Email ID: " + person.email);
            Console.WriteLine("-------------------------------------------");
        }

        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("\nYour address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\nHere are the current people in your address book:\n");
            foreach (var person in People)
            {
                Print(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }


        public static void AddNew()
        {
            Console.WriteLine("Press 1 If you want to add a new Contact to the Address Book");
            switch (Console.ReadLine())
            {
                case "1":

                    NewContact();
                    ListPeople();
                    break;

                default:
                    Console.WriteLine("The choice you made is not valid, please try again");
                    break;
            }

        }
    }
}
