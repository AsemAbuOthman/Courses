#include <iostream>
#include <vector>

using namespace std;

struct stEmployee 
{
	string FirstName;
	string LastName;
	short Age;
	int Salary;
};

int main()
{
	vector<stEmployee> Employee;

	stEmployee tempEmployee;

	tempEmployee.FirstName = "Asem ";
	tempEmployee.LastName = "Abu Othman";
	tempEmployee.Age = 21;
	tempEmployee.Salary = 0;
	Employee.push_back(tempEmployee);

	tempEmployee.FirstName = "Abd ";
	tempEmployee.LastName = "Al Daraghma";
	tempEmployee.Age = 21;
	tempEmployee.Salary = 2000;
	Employee.push_back(tempEmployee);

	tempEmployee.FirstName = "Ziad ";
	tempEmployee.LastName = "Al Sayeh";
	tempEmployee.Age = 21;
	tempEmployee.Salary = 3000;
	Employee.push_back(tempEmployee);

	tempEmployee.FirstName = "Khalil ";
	tempEmployee.LastName = "al Ali";
	tempEmployee.Age = 21;
	tempEmployee.Salary = 4000;
	Employee.push_back(tempEmployee);

	for (stEmployee employee : Employee)
	{
		cout << "-------------------------------------------" << endl;
		cout << "First Name : " << employee.FirstName << endl;
		cout << "Last Name  : " << employee.LastName << endl;
		cout << "Age        : " << employee.Age << endl;
		cout << "Salary     : " << employee.Salary << endl;
		cout << "-------------------------------------------" << endl;

		cout << endl;
	}

	cout << endl;

	return 0;
}

