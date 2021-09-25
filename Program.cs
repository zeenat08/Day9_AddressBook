using System;

namespace DAY9_Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_Details.AddPersonsDetails();
            Console.WriteLine("Welcome To Address Book Programm");
            Console.WriteLine("\n\n");
            #region
            UC1_Details.AddPersonsDetails();
            #endregion


            #region
            UC2_Add_Contacts.NewContact();
            UC2_Add_Contacts.ListPeople();
            UC2_Add_Contacts.AddNew();
            #endregion

            #region
            UC3_UpdateExistingContacts.NewContact();
            UC3_UpdateExistingContacts.ListAllContacts();
            UC3_UpdateExistingContacts.Update();
            //List<string>[UC3_UpdateExistingContacts.People].FirstName.equals(firstname)
            #endregion

            #region
            UC4_DeleteContact.NewContact();
            UC4_DeleteContact.ListContacts();
            UC4_DeleteContact.RemovePerson();
            #endregion

            #region
            UC5_AddMultipleContacts.NewContact();
            UC5_AddMultipleContacts.ListPeople();
            UC5_AddMultipleContacts.AddNew();
            #endregion

            #region
            UC6_UniqueAddress.AddUniqueAddress();
            UC6_UniqueAddress.ListAllPeople();
            UC6_UniqueAddress.ContactDetails();
            #endregion


        }
    }
}
