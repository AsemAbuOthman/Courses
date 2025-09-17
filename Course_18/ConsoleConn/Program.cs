using System;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace ConsoleConn
{
    internal class Program
    {
        static string ConnString = "Server = .; Database = ContactsDB; Integrated Security=SSPI;Persist Security Info=False ";

        static void PrintAllContacts() 
        {

            string query = "select * from Contacts;";

            SqlConnection Conn = new SqlConnection(ConnString);

            SqlCommand Cmd = new SqlCommand(query, Conn);

            try 
            {
                Conn.Open();


                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"First Name : {FirstName}");
                    Console.WriteLine($"Last Name  : {LastName}");
                    Console.WriteLine($"Email      : {Email}");
                    Console.WriteLine($"Phone      : {Phone}");
                    Console.WriteLine($"Address    : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");

                    Console.WriteLine();

                }

                reader.Close();
                Conn.Close();

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error : {0}", ex.Message);
            }
        }

        static void PrintAllContactsWithFirstName(string firstName)
        {

            string query = "select * from Contacts where FirstName = @FirstName;";

            SqlConnection Conn = new SqlConnection(ConnString);

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@FirstName", firstName);

            try
            {
                Conn.Open();


                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"First Name : {FirstName}");
                    Console.WriteLine($"Last Name  : {LastName}");
                    Console.WriteLine($"Email      : {Email}");
                    Console.WriteLine($"Phone      : {Phone}");
                    Console.WriteLine($"Address    : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");

                    Console.WriteLine();

                }

                reader.Close();
                Conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {0}", ex.Message);
            }
        }

        static void SearchContactsStartsWith(string StartWith)
        {

            string query = "select * from Contacts where FirstName like '' + @StartWith + '%' ;";

            SqlConnection Conn = new SqlConnection(ConnString); 

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@StartWith", StartWith);

            try
            {
                Conn.Open();


                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"First Name : {FirstName}");
                    Console.WriteLine($"Last Name  : {LastName}");
                    Console.WriteLine($"Email      : {Email}");
                    Console.WriteLine($"Phone      : {Phone}");
                    Console.WriteLine($"Address    : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");

                    Console.WriteLine();

                }

                reader.Close();
                Conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {0}", ex.Message);
            }
        }

        static void SearchContactsEndsWith(string EndsWith)
        {

            string query = "select * from Contacts where FirstName like '%' + @EndsWith + '' ;";

            SqlConnection Conn = new SqlConnection(ConnString);

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@EndsWith", EndsWith);

            try
            {
                Conn.Open();


                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"First Name : {FirstName}");
                    Console.WriteLine($"Last Name  : {LastName}");
                    Console.WriteLine($"Email      : {Email}");
                    Console.WriteLine($"Phone      : {Phone}");
                    Console.WriteLine($"Address    : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");

                    Console.WriteLine();

                }

                reader.Close();
                Conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {0}", ex.Message);
            }
        }

        static void SearchContactsContains(string Contains)
        {

            string query = "select * from Contacts where FirstName like '%' + @Contains + '%' ;";

            SqlConnection Conn = new SqlConnection(ConnString);

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@Contains", Contains);

            try
            {
                Conn.Open();


                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"First Name : {FirstName}");
                    Console.WriteLine($"Last Name  : {LastName}");
                    Console.WriteLine($"Email      : {Email}");
                    Console.WriteLine($"Phone      : {Phone}");
                    Console.WriteLine($"Address    : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");

                    Console.WriteLine();

                }

                reader.Close();
                Conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {0}", ex.Message);
            }
        }

        static void PrintAllContactsWithFirstNameAndCountry(string firstName, int countryID)
        {

            string query = "select * from Contacts where FirstName = @FirstName and CountryID = @CountryID;";

            SqlConnection Conn = new SqlConnection(ConnString);

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@FirstName", firstName);
            Cmd.Parameters.AddWithValue("@CountryID", countryID);

            try
            {
                Conn.Open();


                SqlDataReader reader = Cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ContactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string LastName = (string)reader["LastName"];
                    string Email = (string)reader["Email"];
                    string Phone = (string)reader["Phone"];
                    string Address = (string)reader["Address"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"First Name : {FirstName}");
                    Console.WriteLine($"Last Name  : {LastName}");
                    Console.WriteLine($"Email      : {Email}");
                    Console.WriteLine($"Phone      : {Phone}");
                    Console.WriteLine($"Address    : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");

                    Console.WriteLine();

                }

                reader.Close();
                Conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {0}", ex.Message);
            }
        }

        static string GetFirstName(int CountryID) 
        {
            SqlConnection Conn = new SqlConnection(ConnString);

            string query = "select FirstName from Contacts where CountryID = @CountryID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            string FirstName = "";

            Cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Conn.Open();

                object result = Cmd.ExecuteScalar();


                if (result != null)
                {
                    FirstName = result.ToString();
                }

            }
            catch (Exception ex) 
            {

                Console.WriteLine($"Error : {ex.Message}");
            }

            Conn.Close ();

            return FirstName;
        }

        public struct stContact
        {
            public int ContactID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }

        }

        static bool FindContactByID(int ContactID, ref stContact ContactInfo) 
        {
            bool isFound = false;

            SqlConnection Conn = new SqlConnection (ConnString);

            string query = "Select * from Contacts where ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    ContactInfo.ContactID = Convert.ToInt32(reader["ContactID"]);
                    ContactInfo.FirstName = (string)reader["FirstName"];
                    ContactInfo.LastName = (string)reader["LastName"];
                    ContactInfo.Email = (string)reader["Email"];
                    ContactInfo.Phone = (string)reader["Phone"];
                    ContactInfo.Address = (string)reader["Address"];
                    ContactInfo.CountryID = Convert.ToInt32(reader["CountryID"]);
                    isFound = true;

                }
                else 
                {
                    isFound = false;
                }

                reader.Close();
                Conn.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isFound;
        }

        static void AddNewContact(stContact newContact) 
        {
            SqlConnection Conn = new SqlConnection(ConnString);

            string query = @"insert into Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                            values(@FirstName, @LastName, @Email, @Phone, @Address, @CountryID);
                            select scope_identity();";


            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@FirstName", newContact.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newContact.LastName);
            Cmd.Parameters.AddWithValue("@Email", newContact.Email);
            Cmd.Parameters.AddWithValue("@Phone", newContact.Phone);
            Cmd.Parameters.AddWithValue("@Address", newContact.Address);
            Cmd.Parameters.AddWithValue("@CountryID", newContact.CountryID);

            try 
            { 
                Conn.Open();

                object result = Cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    Console.WriteLine($"Rows inserted Succefully.");
                    Console.WriteLine($"Newly inserted ID: {insertedID}");
                }
                else 
                {
                    Console.WriteLine("Rows insertion Failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Conn.Close();
        }

        static void UpdateContact(int ContactID, stContact ContactInfo) 
        {
            SqlConnection Conn = new SqlConnection(ConnString);

            string query = @"UPDATE Contacts set
                            FirstName = @FirstName,
                            LastName = @LastName,
                            Email = @Email,
                            Phone = @Phone,
                            Address = @Address,
                            CountryID = @CountryID
                            WHERE ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            Cmd.Parameters.AddWithValue("@Email", ContactInfo.Email);
            Cmd.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            Cmd.Parameters.AddWithValue("@Address", ContactInfo.Address);
            Cmd.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);
            Cmd.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Conn.Open();

                int rowsAffected = Cmd.ExecuteNonQuery();

                if (rowsAffected > 0) 
                {
                    Console.WriteLine("Rows updated Successfully");
                }
                else 
                {
                    Console.WriteLine("Rows updating Failed");

                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            Conn.Close();

        }

        static void DeleteContact(int ContactID)
        {
            SqlConnection Conn = new SqlConnection (ConnString);

            string query = @"DELETE FROM Contacts
                            WHERE ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@ContactID", ContactID);

            try 
            {
                Conn.Open ();

                int rowsAffected = Cmd.ExecuteNonQuery ();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Rows deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Rows deletion Failed");

                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

        }

        static void Main(string[] args)
        {

            stContact ContactInfo = new stContact();

            stContact Contact = new stContact();

            Contact.FirstName = "Ammar";
            Contact.LastName = "Abu Othman";
            Contact.Email = "ammarabuothman@gmail.com";
            Contact.Phone = "0778912322";
            Contact.Address = "New York";
            Contact.CountryID = 1;


            //AddNewContact(Contact);
            //UpdateContact(1, Contact);
            DeleteContact(1);

            //if (FindContactByID(1, ref ContactInfo))
            //{
            //    Console.WriteLine($"Contact ID : {ContactInfo.ContactID}");
            //    Console.WriteLine($"First Name : {ContactInfo.FirstName}");
            //    Console.WriteLine($"Last Name  : {ContactInfo.LastName}");
            //    Console.WriteLine($"Email      : {ContactInfo.Email}");
            //    Console.WriteLine($"Phone      : {ContactInfo.Phone}");
            //    Console.WriteLine($"Address    : {ContactInfo.Address}");
            //    Console.WriteLine($"Country ID : {ContactInfo.CountryID}");

            //    Console.WriteLine();
            //}
            //else 
            //{
            //    Console.WriteLine("Conact with this ContactID was not Found :-(\n");

            //}

            Console.ReadKey();
        }
    }
}
