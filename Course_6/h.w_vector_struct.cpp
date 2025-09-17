#include <iostream>
#include <string>// for getline
#include <vector>

using namespace std;

struct stEmployee 
{
	string FullName;
	short Age;
	int Salary;
};

void ReadEmployeeInfo(vector <stEmployee> &Employee) 
{
	stEmployee tempEmployee;

	char wantEnterMore = 'Y';


	while (wantEnterMore == 'Y' || wantEnterMore == 'y')
	{
		cout << "Plz enter your full name: ";
		cin.ignore();
		getline(cin, tempEmployee.FullName);

		cout << "\nPlz enter your age : ";
		cin >> tempEmployee.Age;

		cout << "\nPlz enter your salary : ";
		cin >> tempEmployee.Salary;

		cout << "\nDo you want to add another employee ? (Y/N) ? ";
		cin >> wantEnterMore;

		cout << endl << endl;

		Employee.push_back(tempEmployee);
	}
}

void PrintEmployeeInfo(vector <stEmployee> &Employee)
{
	for (stEmployee &employee : Employee) 
	{
		cout << "********--------------------*********" << endl;
		cout << "Full Name : " << employee.FullName << endl;
		cout << "Age       : " << employee.Age << endl;
		cout << "Salary    : " << employee.Salary << endl;
		cout << "********--------------------*********" << endl;

		cout << endl;
	}
}

int main()
{
	vector <stEmployee> Employee;

	ReadEmployeeInfo(Employee);
	PrintEmployeeInfo(Employee);

	return 0;
}

