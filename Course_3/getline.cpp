/*
Relational Operators	(== , != , >= , <= , >, <)
Assinment Operators		(=, +=, -=, *=, /=, %=)
Arthimatice Opertaors	(+, -, *, / , %)
Logical Operators		(!, &&, || )
*/

#include <iostream>
#include <string>

using namespace std;

int main()
{
	int employeeNum;
	string name;
	string country;

	cout << "Plz enter employee number : ";
	cin >> employeeNum;

	cout << "\nPlz enter employee name : ";
	cin.ignore(1, '\n');
	getline(cin, name);

	cout << "\nPlz enter country : ";
	cin >> country;
	
	cout << "Number : " << employeeNum << " Name : " << name << " Coutnry : " << country << endl;

	return 0;
}