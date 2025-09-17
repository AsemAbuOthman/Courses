using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


namespace ContactsDataLayer
{
    public class clsContactsDataAccess
    {
        public static bool GetContactInfoByID(int ContactID, ref string FirstName, ref string LastName,
                ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth,
                ref int CountryID, ref string ImagePath)
        {

            bool isFound = false;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = @"SELECT FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath FROM
                            Contacts WHERE ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    CountryID = (int)reader["CountryID"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["ImagePath"] != System.DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];

                    }
                    else
                    {
                        ImagePath = "";

                    }

                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                Conn.Close();
            }

            return isFound;
        }

        public static int AddNewContact(string FirstName, string LastName, string Email,
                string Phone, string Address, DateTime DateOfBirth,
                string ImagePath, int CountryID)
        {
            int ContactID = -1;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = @"INSERT INTO Contacts (FirstName, LastName, Email,
                        Phone, Address, DateOfBirth, ImagePath, CountryID)
                        Values(@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @ImagePath, @CountryID);
                        SELECT SCOPE_IDENTITY();";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@FirstName", FirstName);
            Cmd.Parameters.AddWithValue("@LastName", LastName);
            Cmd.Parameters.AddWithValue("@Email", Email);
            Cmd.Parameters.AddWithValue("@Phone", Phone);
            Cmd.Parameters.AddWithValue("@Address", Address);
            Cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Cmd.Parameters.AddWithValue("@CountryID", CountryID);


            if (ImagePath != "")
            {
                Cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }


            try
            {
                Conn.Open();

                object result = Cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ContactID = insertedID;
                }

            }
            catch (Exception ex)
            {
                ContactID = -1;
            }
            finally
            {
                Conn.Close();
            }

            return ContactID;



        }


        public static bool UpdateContact(int ContactID, string FirstName, string LastName, string Email,
          string Phone, string Address, DateTime DateOfBirth,
          string ImagePath, int CountryID)
        {
            int rowsAffected = 0;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = @"UPDATE Contacts SET
                                FirstName = @FirstName,
                                LastName = @LastName,
                                Email = @Email,
                                Phone = @Phone,
                                Address = @Address,
                                DateOfBirth = @DateOfBirth,
                                ImagePath = @ImagePath,
                                CountryID = @CountryID                      
                                WHERE ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@ContactID", ContactID);
            Cmd.Parameters.AddWithValue("@FirstName", FirstName);
            Cmd.Parameters.AddWithValue("@LastName", LastName);
            Cmd.Parameters.AddWithValue("@Email", Email);
            Cmd.Parameters.AddWithValue("@Phone", Phone);
            Cmd.Parameters.AddWithValue("@Address", Address);
            Cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Cmd.Parameters.AddWithValue("@CountryID", CountryID);


            if (ImagePath != "")
            {
                Cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                Conn.Open();
                rowsAffected = Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Conn.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteContact(int ContactID) 
        {
            int rowsAffected = 0;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = @"DELETE Contacts                     
                                WHERE ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Conn.Open();
                rowsAffected = Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Conn.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllContacts()
        {
            DataTable dt = new DataTable();

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT * FROM Contacts;";

            SqlCommand Cmd = new SqlCommand(query, Conn);


            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch 
            {
                
            }
            finally
            {
                Conn.Close();
            }

            return dt;
        }

        public static bool IsContactExist(int ID) 
        {
            bool isFound = false;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT Found = 1 FROM Contacts WHERE ContactID = @ContactID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();                

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally 
            {
                Conn.Close(); 
            }

            return isFound;
        }


    }

    public class clsCountriesDataAccess 
    {
        public static bool GetCountryByID(int CountryID, ref string CountryName, ref string Code, ref string PhoneCode)
        {
            bool isFound = false;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT CountryName, Code, PhoneCode FROM Countries WHERE CountryID = @CountryID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"];

                    if (reader["Code"] != System.DBNull.Value)
                    {

                        Code = (string)reader["Code"];

                    }
                    else 
                    {
                        Code = "";

                    }

                    if (reader["PhoneCode"] != System.DBNull.Value)
                    {
                        PhoneCode = (string)reader["PhoneCode"];

                    }
                    else
                    {
                        PhoneCode = "";
                    }

                   
                }
                else
                {
                    isFound = false;
                    CountryName = "";
                    Code = "";
                    PhoneCode = "";
                }

                reader.Close();

            }
            catch
            {
                isFound = false;
            }
            finally
            {
                Conn.Close();
            }

            return isFound;
        }

        public static bool GetCountryByName(string CountryName, ref int CountryID, ref string Code, ref string PhoneCode)
        {
            bool isFound = false;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryID = (int)reader["CountryID"];

                    if (reader["Code"] != System.DBNull.Value) 
                        Code = (string)reader["Code"];
                    else
                        Code = "";

                    if (reader["PhoneCode"] != System.DBNull.Value)
                        PhoneCode = (string)reader["PhoneCode"];
                    else
                        PhoneCode = "";

                }
                else
                {
                    isFound = false;
                    CountryID = -1;
                    PhoneCode = "";
                    Code = "";

                }

                reader.Close();

            }
            catch
            {
                isFound = false;
            }
            finally
            {
                Conn.Close();
            }

            return isFound;
        }

        public static int AddNewCountry(string CountryName, string Code, string PhoneCode)
        {
            int CountryID = -1;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = @"INSERT INTO Countries (CountryName, Code, PhoneCode)
                        Values(@CountryName, @Code, @PhoneCode);
                        SELECT SCOPE_IDENTITY();";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@CountryName", CountryName);
            Cmd.Parameters.AddWithValue("@Code", Code);
            Cmd.Parameters.AddWithValue("@PhoneCode", PhoneCode);


            try
            {
                Conn.Open();

                object result = Cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CountryID = insertedID;
                }

            }
            catch (Exception ex)
            {
                CountryID = -1;
            }
            finally
            {
                Conn.Close();
            }

            return CountryID;

        }

        public static bool UpdateCountry(int CountryID, string CountryName, string Code, string PhoneCode) 
        {
            int rowsAffected = 0;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = @"UPDATE Countries SET
                            CountryName = @CountryName
                            Code = @Code
                            PhoneCode = @PhoneCode
                            WHERE CountryID = @CountryID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@CountryID", CountryID);
            Cmd.Parameters.AddWithValue("@CountryName", CountryName);
            Cmd.Parameters.AddWithValue("@Code", Code);
            Cmd.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try 
            {

                Conn.Open();

                rowsAffected = Cmd.ExecuteNonQuery();

            }
            catch (Exception ex) 
            { 

            } 
            finally 
            {
                Conn.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteCountry(int CountryID) 
        {
            int rowsAffected = 0;

            SqlConnection Conn = new SqlConnection (clsDataAccessSettings.ConnString);

            string query = @"DELETE FROM Countries
                            WHERE CountryID = @CountryID";

            SqlCommand Cmd = new SqlCommand (query, Conn);

            Cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try 
            {
                Conn.Open();

                rowsAffected = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 

            } 
            finally
            {
                Conn.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllCountry() 
        {
            DataTable dt = new DataTable();

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT * FROM Countries;";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            try 
            {
                Conn.Open ();

                SqlDataReader reader = Cmd.ExecuteReader();

                if (reader.HasRows) 
                {
                    dt.Load(reader);
                }

                reader.Close();

            } 
            catch (Exception ex) 
            {

            } 
            finally 
            { 
                Conn.Close();
            }

            return dt;
        }

        public static bool IsCountryExist(int CountryID) 
        {
            bool isFound = false;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT Found = 1 FROM Countries WHERE CountryID = @CountryID";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                Conn.Close();
            }

            return isFound;
        }

        public static bool IsCountryExist(string CountryName)
        {
            bool isFound = false;

            SqlConnection Conn = new SqlConnection(clsDataAccessSettings.ConnString);

            string query = "SELECT Found = 1 FROM Countries WHERE CountryName = @CountryName";

            SqlCommand Cmd = new SqlCommand(query, Conn);

            Cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Conn.Open();

                SqlDataReader reader = Cmd.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                Conn.Close();
            }

            return isFound;
        }


    }

}


