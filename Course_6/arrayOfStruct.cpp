#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

struct stContact
{
	string Phone = "";
	string Email = "";
};

struct stPerson 
{
	string FirstName = "";
	string LastName = "";
	unsigned short Age = 0;
	stContact Contact;
};



int main()
{
	stPerson Person1, Person2, Person3, Person4;

	Person1.FirstName = "Asem";
	Person1.LastName = "Abu Othman";
	Person1.Age = 21;
	Person1.Contact.Phone = "+962795616423";
	Person1.Contact.Email = "asem_abuothman@gmail.com";

	Person2.FirstName = "Abd almounaem";
	Person2.LastName = "Al Draghma";
	Person2.Age = 22;
	Person2.Contact.Phone = "+962795464121";
	Person2.Contact.Email = "almounaem_draghma@gmail.com";

	Person3.FirstName = "Ziad";
	Person3.LastName = "Firas";
	Person3.Age = 20;
	Person3.Contact.Phone = "+962795450021";
	Person3.Contact.Email = "ziad_firas@gmail.com";

	Person4.FirstName = "Khalil";
	Person4.LastName = "Al Ali";
	Person4.Age = 24;
	Person4.Contact.Phone = "+962795464121";
	Person4.Contact.Email = "khalil_alali@gmail.com";

	stPerson stArray[] = { Person1, Person2, Person3, Person4};

	for (stPerson Person : stArray)

	{
		cout << "***************************************" << endl;
		cout << "First Name: " << Person.FirstName << endl;
		cout << "Age\t  : " << Person.Age << endl;
		cout << "Email\t  : " << Person.Contact.Email << endl;
		cout << "***************************************\n" << endl;
	}

	return 0;
}
