using System;
using System.Data;
using System.Net;
using System.Security.Policy;
using ContactsDataLayer;

namespace ContactsBuisnessLayer
{
    enum enMode
    {
        AddNew,
        Update
    }

    public class clsContact 
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
        enMode Mode;
        public clsContact(int ID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath) 
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;

            Mode = enMode.Update;
        }

        private bool _AddNewContact() 
        {
            this.ID = clsContactsDataAccess.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone,
                        this.Address, this.DateOfBirth, this.ImagePath, this.CountryID);

            return (this.ID != -1);
        }

        public static clsContact Find(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;

            if (clsContactsDataAccess.GetContactInfoByID(ID, ref FirstName, ref LastName, ref Email, ref Phone,
                        ref Address, ref DateOfBirth, ref CountryID, ref ImagePath))
            {
                return new clsContact(ID, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        private bool _UpdateContact() 
        {
            return clsContactsDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone,
                        this.Address, this.DateOfBirth, this.ImagePath, this.CountryID);
        }

        public clsContact() 
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.ImagePath = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;

            Mode = enMode.AddNew;
        }


        public bool Save() 
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {
                        Mode = enMode.Update;

                        return true;
                    }
                    else 
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateContact();

            }

            return false;
        }

        public static bool DeleteContact(int ID) 
        {
            return clsContactsDataAccess.DeleteContact(ID);
        }

        public static DataTable GetAllContacts() 
        {
            return clsContactsDataAccess.GetAllContacts();
        }

        public static bool IsContactExist(int ID)
        {
            return clsContactsDataAccess.IsContactExist(ID);
        }


    }

    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }

        enMode Mode;
        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            this.Code = "";
            this.PhoneCode = "";
        }

        public clsCountry(int CountryID, string CountryName, string Code, string PhoneCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;

            Mode = enMode.Update;
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "", Code = "", PhoneCode = "";

            if (clsCountriesDataAccess.GetCountryByID(CountryID, ref CountryName, ref Code, ref PhoneCode))
            {
                return new clsCountry(CountryID, CountryName, Code, PhoneCode);
            }
            else
            {
                return null;
            }
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            string Code = "", PhoneCode = "";

            if (clsCountriesDataAccess.GetCountryByName(CountryName, ref CountryID, ref Code, ref PhoneCode))
            {
                return new clsCountry(CountryID, CountryName, Code, PhoneCode);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountriesDataAccess.AddNewCountry(this.CountryName, this.Code, this.PhoneCode);

            return (this.CountryID != -1);
        }

        private bool _UpdateCountry()
        {

            return clsCountriesDataAccess.UpdateCountry(this.CountryID, this.CountryName, this.Code, this.PhoneCode);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;

                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCountry();

            }

            return false;
        }

        public static bool DeleteCountry(int CountryID)
        {
            return clsCountriesDataAccess.DeleteCountry(CountryID);
        }

        public static DataTable GetAllCountry()
        {
            return clsCountriesDataAccess.GetAllCountry();
        }

        public static bool IsCountryExist(int CountryID)
        {
            return clsCountriesDataAccess.IsCountryExist(CountryID);
        }

        public static bool IsCountryExist(string CountryName)
        {
            return clsCountriesDataAccess.IsCountryExist(CountryName);
        }

    }

}
