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
	string string1, string2, string3;

	cout << "Plz enter string1 ?" << endl;
	getline(cin, string1);

	cout << "\nPlz enter string2 ?" << endl;
	cin >> string2;

	cout << "\nPlz enter string3 ?" << endl;
	cin >> string3;

	cout << "**************************" << endl;

	cout << "The length of the string1 is " << string1.length() << endl;
	cout << "Characters at 0, 2, 4, 7 are: "
		<< string1[0] << " "
		<< string1[2] << " "
		<< string1[4] << " "\
		<< string1[7] << endl;
	cout << "Conactenating string2 & string3 = " << string2 + string3 << endl;
	cout << string2 << " * " << string3 << " = " << stoi(string2) * stoi(string3);

	return 0;
}