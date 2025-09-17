using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DataAdapter
{
    internal class Program
    {
        static string ConnString = "Server = .; Database = HR_Departments; Integrated Security=SSPI;Persist Security Info=False ";


        static void Main(string[] args)
        {
            
            DataSet dataSet = new DataSet();

            SqlConnection Conn = new SqlConnection(ConnString);

            string query = "SELECT * FROM Employees";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Conn);


            Conn.Open();

            dataAdapter.Fill(dataSet, "Employees");

            Conn.Close();

            DataTable EmployeesDataTable = dataSet.Tables["Employees"];

            foreach (DataRow row in EmployeesDataTable.Rows) 
            {
                Console.WriteLine($"{row["ID"]} {row["FirstName"]} {row["LastName"]}");
            }

            Console.ReadKey();

            Conn.Open ();

            dataAdapter.Update(dataSet, "Employees");            

        }
    }
}
