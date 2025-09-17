#include <iostream>
#include <string>

using namespace std;

int numOfPersons;

struct strPersonsInfo 
{
	string FirstName;
	string LastName;
	short Age;
	string Phone;
};

void ReadPersonInfo(strPersonsInfo &Person)
{

	cout << "Plz enter your first name : ";
	cin >> Person.FirstName;

	cout << "Plz enter your last name : ";
	cin >> Person.LastName;

	cout << "Plz enter your age : ";
	cin >> Person.Age;

	cout << "Plz enter your Phone number : ";
	cin >> Person.Phone;

	cout << endl;
}

void PrintPersonInfo(strPersonsInfo Person) 
{
	cout << "*********************************" << endl;
	cout << "First Name : " << Person.FirstName << endl;
	cout << "Last Name : " << Person.LastName << endl;
	cout << "Age : " << Person.Age << endl;
	cout << "Phone : " << Person.Phone << endl;
	cout << "*********************************" << endl << endl;

}

void ReadAllPersonsInfo(strPersonsInfo Persons[100])
{

	cout << "How many pesron you want to enter ? 1 to 100 ? ";
	cin >> numOfPersons;

	for (int i = 0; i < numOfPersons; i++) 
	{
		cout << "\nEnter information of person " << i + 1 << endl;
		cout << "*********************************" << endl;
		ReadPersonInfo(Persons[i]);
		
	}

}

void PrintAllPersonsInfo(strPersonsInfo Persons[100])
{
	for (int i = 0; i < numOfPersons; i++)
	{
		cout << "Person " << i + 1 << " Info:" << endl;
		PrintPersonInfo(Persons[i]);
	}
}



int main()
{
	strPersonsInfo Persons[100];
	ReadAllPersonsInfo(Persons);
	PrintAllPersonsInfo(Persons);

	return 0;
}