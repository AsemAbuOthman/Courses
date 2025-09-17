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
	string fullName;

	cout << "Plz enter your name : ";
	getline(cin, fullName);

	cout << "Your name is " << fullName;

	return 0;
}