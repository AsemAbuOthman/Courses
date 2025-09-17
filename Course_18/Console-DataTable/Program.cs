using System;
using System.Data;
using System.Linq;


namespace Console_DataTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmloyeeDataTable = new DataTable();

            //EmloyeeDataTable.Columns.Add("ID", typeof(int));
            //EmloyeeDataTable.Columns.Add("Name", typeof(string));
            //EmloyeeDataTable.Columns.Add("Country", typeof(string));
            //EmloyeeDataTable.Columns.Add("Salary", typeof(int));
            //EmloyeeDataTable.Columns.Add("DateOfBirth", typeof(DateTime));

            DataColumn dataColumn;

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(int);
            dataColumn.ColumnName = "ID";
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementSeed = 1;
            dataColumn.AutoIncrementStep = 1;
            dataColumn.Unique = true;

            dataColumn.Caption = "EmployeeID";
            dataColumn.ReadOnly = true;
            EmloyeeDataTable.Columns.Add(dataColumn);

            //

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(string);
            dataColumn.ColumnName = "Name";
            dataColumn.Unique = false;

            dataColumn.Caption = "EmployeeName";
            dataColumn.ReadOnly = false;
            EmloyeeDataTable.Columns.Add(dataColumn);
            
            //

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(string);
            dataColumn.ColumnName = "Country";
            dataColumn.Unique = false;

            dataColumn.Caption = "EmployeeCountry";
            dataColumn.ReadOnly = false;
            EmloyeeDataTable.Columns.Add(dataColumn);

            //

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(int);
            dataColumn.ColumnName = "Salary";

            dataColumn.Caption = "EmployeeSalary";
            dataColumn.ReadOnly = false;
            EmloyeeDataTable.Columns.Add(dataColumn);

            //

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(DateTime);
            dataColumn.ColumnName = "DateOfBirth";
            dataColumn.Unique = false;

            dataColumn.Caption = "EmployeeDateOfBirth";
            dataColumn.ReadOnly = false;
            EmloyeeDataTable.Columns.Add(dataColumn);

            //Primary Keys
            DataColumn[] PKcoulmns = new DataColumn[1];
            PKcoulmns[0] = EmloyeeDataTable.Columns["ID"];
            EmloyeeDataTable.PrimaryKey = PKcoulmns;

            EmloyeeDataTable.Rows.Add(null, "Asem Abu Othman", "Jordan", 32000, DateTime.Now);
            EmloyeeDataTable.Rows.Add(null, "Ammar Abu Othman", "Canada", 2000, DateTime.Now);
            EmloyeeDataTable.Rows.Add(null, "Hassan Abu Othman", "USA", 3000, DateTime.Now);
            EmloyeeDataTable.Rows.Add(null, "Jood Abu Othman", "Egypt", 3200, DateTime.Now);
            EmloyeeDataTable.Rows.Add(null, "Noor Abu Othman", "Russia", 1000, DateTime.Now);
            EmloyeeDataTable.Rows.Add(null, "Ahmad Abu Othman", "Jordan", 1000, DateTime.Now);

            int TotalOfEmployees = 0;
            double SumOfEmployeeSalary = 0;
            double AvgOfEmployeeSalary = 0;
            double MaxOfEmployeeSalary = 0;
            double MinOfEmployeeSalary = 0;

            TotalOfEmployees = EmloyeeDataTable.Rows.Count;
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", string.Empty)) ;
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", string.Empty));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", string.Empty));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", string.Empty));

            Console.WriteLine("Employees List : ");

            foreach (DataRow Record in EmloyeeDataTable.Rows) 
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", Record["ID"], Record["Name"], Record["Country"], Record["Salary"], Record["DateOfBirth"]);
 
            }

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");

            EmloyeeDataTable.DefaultView.Sort = "ID Desc";
            EmloyeeDataTable = EmloyeeDataTable.DefaultView.ToTable();


            TotalOfEmployees = EmloyeeDataTable.Rows.Count;
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", string.Empty));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", string.Empty));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", string.Empty));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", string.Empty));

            Console.WriteLine("Employees List : ");

            foreach (DataRow Record in EmloyeeDataTable.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", Record["ID"], Record["Name"], Record["Country"], Record["Salary"], Record["DateOfBirth"]);

            }

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");

            EmloyeeDataTable.DefaultView.Sort = "Name Asc";
            EmloyeeDataTable = EmloyeeDataTable.DefaultView.ToTable();

            TotalOfEmployees = EmloyeeDataTable.Rows.Count;
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", string.Empty));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", string.Empty));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", string.Empty));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", string.Empty));

            Console.WriteLine("Employees List : ");

            foreach (DataRow Record in EmloyeeDataTable.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", Record["ID"], Record["Name"], Record["Country"], Record["Salary"], Record["DateOfBirth"]);

            }

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");

            EmloyeeDataTable.DefaultView.Sort = "ID Desc";
            EmloyeeDataTable = EmloyeeDataTable.DefaultView.ToTable();


            TotalOfEmployees = EmloyeeDataTable.Rows.Count;
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", string.Empty));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", string.Empty));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", string.Empty));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", string.Empty));

            Console.WriteLine("Employees List After Deletion : ");

            DataRow[] RowsForDelete = EmloyeeDataTable.Select("ID = 2");

            foreach (var Record in RowsForDelete)
            {
                Record.Delete();
            }

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");


            EmloyeeDataTable.DefaultView.Sort = "ID Desc";
            EmloyeeDataTable = EmloyeeDataTable.DefaultView.ToTable();


            TotalOfEmployees = EmloyeeDataTable.Rows.Count;
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", string.Empty));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", string.Empty));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", string.Empty));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", string.Empty));

            Console.WriteLine("Employees List After Update : ");

            DataRow[] RowToUpdate = EmloyeeDataTable.Select("ID = 1");

            foreach (var Record in RowToUpdate)
            {
                Record["Name"] = "Abu Othman";
                Record["Country"] = "UK";

            }

            foreach (var Record in RowToUpdate)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", Record["ID"], Record["Name"], Record["Country"], Record["Salary"], Record["DateOfBirth"]);

            }

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");
            Console.WriteLine("\n//////////////////////////////////////////\n");


            DataRow[] ResultRows;

            ResultRows = EmloyeeDataTable.Select("Country = 'Jordan'");

            foreach (DataRow ResultRow in ResultRows) 
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", ResultRow["ID"], ResultRow["Name"], ResultRow["Country"], ResultRow["Salary"], ResultRow["DateOfBirth"]);
                
            }

            TotalOfEmployees = ResultRows.Count();
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", "Country = 'Jordan'"));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", "Country = 'Jordan'"));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", "Country = 'Jordan'"));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", "Country = 'Jordan'"));

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");




            ResultRows = EmloyeeDataTable.Select("Country = 'Jordan' or Country = 'Egypt'");

            foreach (DataRow ResultRow in ResultRows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", ResultRow["ID"], ResultRow["Name"], ResultRow["Country"], ResultRow["Salary"], ResultRow["DateOfBirth"]);

            }

            TotalOfEmployees = ResultRows.Count();
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", "Country = 'Jordan' or Country = 'Egypt'"));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", "Country = 'Jordan' or Country = 'Egypt'"));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", "Country = 'Jordan' or Country = 'Egypt'"));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", "Country = 'Jordan' or Country = 'Egypt'"));

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");



            ResultRows = EmloyeeDataTable.Select("ID = 1");

            foreach (DataRow ResultRow in ResultRows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t DateOfBirth: {4} ", ResultRow["ID"], ResultRow["Name"], ResultRow["Country"], ResultRow["Salary"], ResultRow["DateOfBirth"]);

            }

            TotalOfEmployees = ResultRows.Count();
            SumOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("SUM(Salary)", "ID = 1"));
            AvgOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("AVG(Salary)", "ID = 1"));
            MaxOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MAX(Salary)", "ID = 1"));
            MinOfEmployeeSalary = Convert.ToDouble(EmloyeeDataTable.Compute("MIN(Salary)", "ID = 1"));

            Console.WriteLine("\n\nTOTAL Of Employees : {0}", TotalOfEmployees);
            Console.WriteLine("SUM Of Employees : {0}", SumOfEmployeeSalary);
            Console.WriteLine("AVG Of Employees : {0}", AvgOfEmployeeSalary);
            Console.WriteLine("MAX Of Employees : {0}", MaxOfEmployeeSalary);
            Console.WriteLine("MIN Of Employees : {0}", MinOfEmployeeSalary);

            Console.WriteLine("\n//////////////////////////////////////////\n");


            Console.ReadKey();

            //EmloyeeDataTable.Clear();


        }

    }
}
