using System;
using System.Data;
using ContactsBuisnessLayer;

namespace ContactsConsoleApp
{


    internal class Program
    {
        static void testFindContact(int ID)
        {
            clsContact Contact = clsContact.Find(ID);

            if (Contact != null)
            {

                Console.WriteLine(Contact.FirstName + " " + Contact.LastName);
                Console.WriteLine(Contact.Email);
                Console.WriteLine(Contact.Phone);
                Console.WriteLine(Contact.Address);
                Console.WriteLine(Contact.DateOfBirth);
                Console.WriteLine(Contact.CountryID);
                Console.WriteLine(Contact.ImagePath);
                Console.WriteLine();

            }
            else 
            {
                Console.WriteLine("Contact [" + ID + "] Not Found!");

            }

        }

        static void testAddNewContact() 
        {
            clsContact Contact = new clsContact();

            Contact.FirstName = "Asem";
            Contact.LastName = "Abu Othman";
            Contact.Email = "asemabuothman@gmail.com";
            Contact.Phone = "0795616423";
            Contact.Address = "Amman";
            Contact.ImagePath = "dsfsadgsdag";
            Contact.DateOfBirth = DateTime.Now;
            Contact.CountryID = 1;

            if (Contact.Save()) 
            {
                Console.WriteLine($"Contact added Successfully with ID = {Contact.ID}");
            }

        }


        static void testUpdateContact(int ID)
        {
            clsContact Contact = clsContact.Find(ID);

            Contact.FirstName = "Ammar";
            Contact.LastName = "Abu Othman";
            Contact.Email = "ammarabuothman@gmail.com";
            Contact.Phone = "0795616423";
            Contact.Address = "Amman";
            Contact.ImagePath = "aaaaaaaaaaaaaaaaaaaaaa";
            Contact.DateOfBirth = DateTime.Now;
            Contact.CountryID = 1;

            if (Contact.Save())
            {
                Console.WriteLine($"Contact Updated Successfully with ID = {ID}");
            }

        }

        static void testDeleteContact(int ID)
        {

            if (clsContact.DeleteContact(ID))
            {

                if (clsContact.IsContactExist(ID))
                {
                    Console.WriteLine($"Contact Deleted Successfullly {ID}");
                }
                else
                {
                    Console.WriteLine($"Contact Deletion Failed {ID}");
                }
               
            }
            else 
            {
                    Console.WriteLine($"Contact is not found with ID : {ID}");
            }

        }

        static void GetAllContacts() 
        {
            DataTable dt = clsContact.GetAllContacts();

            Console.WriteLine("Contacts Data.");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($@" {row["ContactID"]}, {row["FirstName"]}, {row["LastName"]}");
            }
        }

        static void testIsContactExist(int ID) 
        {
            if (clsContact.IsContactExist(ID)) 
            {
                Console.WriteLine("Yes, Contact is there .");
            }
            else
            {
                Console.WriteLine("No, Contact isn't there .");
            }
        }

        static void testFindCountry(int CountryID)
        {
            clsCountry Country = clsCountry.Find(CountryID);

            if (Country != null)
            {

                Console.WriteLine(Country.CountryID + " " + Country.CountryName);

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Country with [" + CountryID + "] Not Found!");

            }

        }

        static void testFindCountry(string CountryName)
        {
            clsCountry Country = clsCountry.Find(CountryName);

            if (Country != null)
            {

                Console.WriteLine(Country.CountryID + " " + Country.CountryName);

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Country with [" + CountryName + "] Not Found!");

            }

        }

        static void testAddNewCountry()
        {
            clsCountry Country = new clsCountry();

            Country.CountryName = "Jordan";
            Country.Code = "123";
            Country.PhoneCode = "962";


            if (Country.Save())
            {
                Console.WriteLine($"Country added Successfully with ID = {Country.CountryID}");
            }

        }

        static void testUpdateCountry(int CountryID)
        {
            clsCountry Country = clsCountry.Find(CountryID);

            Country.CountryName = "Egypt";
            Country.Code = "000";
            Country.PhoneCode = "675";


            if (Country.Save())
            {
                Console.WriteLine($"Contact Updated Successfully with ID = {Country.CountryID}");
            }

        }

        static void testDeleteCountry(int CountryID)
        {

            if (clsCountry.DeleteCountry(CountryID))
            {

                Console.WriteLine($"Contact Deleted Successfullly {CountryID}");

            }
            else
            {
                Console.WriteLine($"Contact Deletion Failed {CountryID}");
            }

        }

        static void GetAllCountries()
        {
            DataTable dt = clsCountry.GetAllCountry();

            Console.WriteLine("Country Data.");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($@" {row["CountryID"]}, {row["CountryName"]}");
            }
        }

        static void testIsCountryExist(int CountryID)
        {
            if (clsCountry.IsCountryExist(CountryID))
            {
                Console.WriteLine("Yes, Country is there .");
            }
            else
            {
                Console.WriteLine("No, Country isn't there .");
            }
        }

        static void testIsCountryExist(string CountryName)
        {
            if (clsCountry.IsCountryExist(CountryName))
            {
                Console.WriteLine("Yes, Country is there .");
            }
            else
            {
                Console.WriteLine("No, Country isn't there .");
            }
        }

        static void Main(string[] args)
        {

            //testFindContact(1);
            //testAddNewContact();
            //testUpdateContact(8);
            //testDeleteContact(8);
            //GetAllContacts();
            //testIsContactExist(7);

            //--------------------//

            //testFindCountry(3);
            //testAddNewCountry();
            //testUpdateCountry(6);
            //testDeleteCountry(6);
            //GetAllCountries();
            //testIsCountryExist(1);
            //testFindCountry("Canada");
            //testIsCountryExist("Canada");

            Console.ReadKey();
        }
    }
}
