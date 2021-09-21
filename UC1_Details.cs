using System;
using System.Collections.Generic;
using System.Text;

namespace DAY9_Address_Book
{
    class UC1_Details
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phonenumber;
        public string email;

        public static void AddPersonsDetails()
        {
            UC1_Details person = new UC1_Details();

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


            Console.WriteLine("\n\nDetails of the Person are given below: ");
            Console.WriteLine("\nFirst Name: " + person.firstname);
            Console.WriteLine("\nLast Name: " + person.lastname);
            Console.WriteLine("\nAddress: " + person.address);
            Console.WriteLine("\nCity: " + person.city);
            Console.WriteLine("\nState: " + person.state);
            Console.WriteLine("\nZip Code: " + person.zipcode);
            Console.WriteLine("\nPhone Number: " + person.phonenumber);
            Console.WriteLine("\nEmail ID: " + person.email);
            Console.WriteLine("-------------------------------------------");

        }
    }
}



