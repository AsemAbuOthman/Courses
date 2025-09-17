#include <iostream>
#include <string>

using namespace std;

struct strInfo 
{
	string FirstName;
	string LastName;
	int Age;
	string Phone;
};

void ReadPersonInfo(strInfo &Persons)
{
	cout << "Enter your first name : ";
	cin >> Persons.FirstName;

	cout << "Enter your last name : ";
	cin >> Persons.LastName;

	cout << "Enter your age : ";
	cin >> Persons.Age;

	cout << "Enter your phone number : ";
	cin >> Persons.Phone;

	cout << "|\t\t|" << endl;
}

void PrintPersonInfo(strInfo Persons)
{
	cout << "********************************" << endl;
	cout << "First name : " << Persons.FirstName << endl;
	cout << "Last name : " << Persons.LastName << endl;
	cout << "Age : " << Persons.Age << endl;
	cout << "Phone : " << Persons.Phone << endl;
	cout << "********************************" << endl;
	cout << "--------------------------------" << endl;
}

void ReadAllPersonsInfo(strInfo Persons[2])
{
	ReadPersonInfo(Persons[0]);
	ReadPersonInfo(Persons[1]);

}

void PrintALlPersonsInfo(strInfo Persons[2])
{
	PrintPersonInfo(Persons[0]);
	PrintPersonInfo(Persons[1]);
}


int main()
{
	strInfo Persons[2];
	ReadAllPersonsInfo(Persons);
	PrintALlPersonsInfo(Persons);



	return 0;
}