using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DataView
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable EmployeeDataTable = new DataTable("EmployeeDataTable");

            EmployeeDataTable.Columns.Add("ID", typeof(int));
            EmployeeDataTable.Columns.Add("Name", typeof(string));
            EmployeeDataTable.Columns.Add("Country", typeof(string));
            EmployeeDataTable.Columns.Add("Salary", typeof(int));
            EmployeeDataTable.Columns.Add("DateOfBirth", typeof(DateTime));

            EmployeeDataTable.Rows.Add(1, "Asem Abu Othman", "Jordan", 2000, DateTime.Now);
            EmployeeDataTable.Rows.Add(2, "Jad Abu Othman", "USA  ", 3000, DateTime.Now);
            EmployeeDataTable.Rows.Add(3, "Jack Abu Othman", "Canada", 1000, DateTime.Now);
            EmployeeDataTable.Rows.Add(4, "Jood Abu Othman", "UK   ", 4000, DateTime.Now);
            EmployeeDataTable.Rows.Add(5, "Noor Abu Othman", "Russia", 10000, DateTime.Now);

            Console.WriteLine("Employees List : \n\n");

            foreach (DataRow row in EmployeeDataTable.Rows) 
            {
                Console.WriteLine("ID : {0}\t Name : {1}\t Country : {2}\t Salary : {3}\t DateOfBirth : {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
            }

            Console.WriteLine("\n");


            DataTable DepartmentDataTable = new DataTable("DepartmentDataTable");

            DepartmentDataTable.Columns.Add("ID", typeof(int));
            DepartmentDataTable.Columns.Add("Name", typeof(string));


            DepartmentDataTable.Rows.Add(1, "HR");
            DepartmentDataTable.Rows.Add(2, "IT");
            DepartmentDataTable.Rows.Add(3, "Finance");

            Console.WriteLine("Departments List : \n\n");

            foreach (DataRow row in DepartmentDataTable.Rows)
            {
                Console.WriteLine("ID : {0}\t Name : {1}",
                    row["ID"], row["Name"]);
            }

            Console.WriteLine("\n");


            DataSet myDataSet = new DataSet();

            myDataSet.Tables.Add(EmployeeDataTable);
            myDataSet.Tables.Add(DepartmentDataTable);

            Console.WriteLine("DataSet List : \n\n");

            foreach (DataRow row in myDataSet.Tables["EmployeeDataTable"].Rows) 
            {
                Console.WriteLine("ID : {0}\t Name : {1}\t Country : {2}\t Salary : {3}\t DateOfBirth : {4}",
                          row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
            }

            Console.WriteLine("\n");


            foreach (DataRow row in myDataSet.Tables["DepartmentDataTable"].Rows)
            {
                Console.WriteLine("ID : {0}\t Name : {1}\t",
                          row["ID"], row["Name"]);
            }

            /////////////


            DataView EmployeeDataView1 = EmployeeDataTable.DefaultView;

            Console.WriteLine("\nEmployees List with DataView : \n\n"); 

            for (int i = 0; i < EmployeeDataView1.Count; i++) 
            {
                Console.WriteLine("{0}\t  , {1}\t  , {2}\t  , {3}\t  , {4}",
                    EmployeeDataView1[i][0], EmployeeDataView1[i][1], EmployeeDataView1[i][2],
                    EmployeeDataView1[i][3], EmployeeDataView1[i][4]);
            }

            EmployeeDataView1.Sort = "Name ASC";

            Console.WriteLine("\n\nEmployees List with DataView after Sorting : \n\n");

            for (int i = 0; i < EmployeeDataView1.Count; i++)
            {
                Console.WriteLine("{0}\t  , {1}\t  , {2}\t  , {3}\t  , {4}",
                    EmployeeDataView1[i][0], EmployeeDataView1[i][1], EmployeeDataView1[i][2],
                    EmployeeDataView1[i][3], EmployeeDataView1[i][4]);
            }

            EmployeeDataView1.RowFilter = "Country in ('USA', 'UK', 'Jordan')";

            Console.WriteLine("\n\nEmployees List with DataView after Filtering : \n\n");

            for (int i = 0; i < EmployeeDataView1.Count; i++)
            {
                Console.WriteLine("{0}\t  , {1}\t  , {2}\t  , {3}\t  , {4}",
                    EmployeeDataView1[i][0], EmployeeDataView1[i][1], EmployeeDataView1[i][2],
                    EmployeeDataView1[i][3], EmployeeDataView1[i][4]);
            }

            

            Console.ReadKey();
        }
    }
}
