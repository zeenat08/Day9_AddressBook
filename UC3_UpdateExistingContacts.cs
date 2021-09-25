using System;
using System.Collections.Generic;
using System.Text;

namespace DAY9_Address_Book
{
    class UC3_UpdateExistingContacts
    { 
          public string firstname;
          public string lastname;
          public string address;
          public string city;
          public string state;
          public string zipcode;
          public string phonenumber;
          public string email;

          public static List<UC3_UpdateExistingContacts> People = new List<UC3_UpdateExistingContacts>();

          public static void NewContact()
          {
                UC3_UpdateExistingContacts person = new UC3_UpdateExistingContacts();

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


            public static void PrintingDetails(UC3_UpdateExistingContacts person)
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

            public static void ListAllContacts()
            {
                if (People.Count == 0)
                {
                    Console.WriteLine("Your address book is empty. Press any key to continue.");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Here are the current people in your address book:\n");
                foreach (var person in People)
                {
                    PrintingDetails(person);
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();

            }

            public static void Update()
            {
                Console.WriteLine("Press 1 If you want to edit any Contact in the Address Book");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter the First Name of the Person U want to update");
                        string firstname = Console.ReadLine();
                        UC3_UpdateExistingContacts findperson = People.Find(x => x.firstname.ToLower() == firstname.ToLower());
                        if (findperson == null)
                        {
                            Console.WriteLine("That person could not be found");
                        }

                        Console.WriteLine("Are you sure you want to remove this person and enter new in your address book? Enter --> (Y/N)");
                        PrintingDetails(findperson);
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            People.Remove(findperson);
                            Console.WriteLine("Person removed. Press any key to continue.");
                            Console.ReadKey();
                        }
                        if (Console.ReadKey().Key == ConsoleKey.N)
                        {
                            Console.WriteLine("OKK. Press any key to continue.");
                        }

                        ListAllContacts();

                        //NewContact();
                        //for (int i = 0; i < People.Count; i++)
                        //{
                        //    if (People[i].firstname.Equals(firstname))
                        //    {
                        //        Console.WriteLine("Press 1 if u want to edit the FirstName");
                        //        Console.WriteLine("Press 2 if u want to edit the LastName");
                        //        Console.WriteLine("Press 3 if u want to edit the Address");
                        //        Console.WriteLine("Press 4 if u want to edit the City");
                        //        Console.WriteLine("Press 5 if u want to edit the State");
                        //        Console.WriteLine("Press 6 if u want to edit the Zip Code");
                        //        Console.WriteLine("Press 7 if u want to edit the Phone Number");
                        //        Console.WriteLine("Press 8 if u want to edit the Email Id");
                        //        switch(Console.ReadLine())
                        //        {
                        //            case "1":
                        //                Console.Write("Enter new FirstName: ");
                        //                break;
                        //        }
                        //    }
                        //}


                        break;
                    default:
                        Console.WriteLine("The choice you made is not valid, please try again");
                        break;
                }
            }
        }
    }

   