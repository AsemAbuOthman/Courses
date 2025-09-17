/*
Relational Operators	(== , != , >= , <= , >, <)
Assinment Operators		(=, +=, -=, *=, /=, %=)
Arthimatice Opertaors	(+, -, *, / , %)
Logical Operators		(!, &&, || )
*/

#include <iostream>

using namespace std;

struct strInfo 
{
	string FirstName;
	string LastName;
	int Age;
	string PhoneNum;
};

void ReadInfo(strInfo &Info) 
{
	cout << "\nEnter your first name : ";
	cin >> Info.FirstName;

	cout << "\nEnter your last name : ";
	cin >> Info.LastName;

	cout << "\nEnter your age : ";
	cin >> Info.Age;

	cout << "\nEnter your phone number : ";
	cin >> Info.PhoneNum;

	cout << endl;
}

void PrintInfo(strInfo Info) 
{

	cout << "************************\n" << endl;

	cout << "Your name is " << Info.FirstName << " " << Info.LastName << endl;
	cout << "Your age is " << Info.Age << endl;
	cout << "Your phone number is " << Info.PhoneNum << endl;

	cout << "\n*************************\n" << endl;
}

int main()
{
	strInfo Person1Info;

	ReadInfo(Person1Info);
	PrintInfo(Person1Info);

	strInfo Person2Info;

	ReadInfo(Person2Info);
	PrintInfo(Person2Info);

	return 0;
}