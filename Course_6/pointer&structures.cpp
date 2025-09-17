#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

struct stEmployee 
{
	string FirstName;
	string LastName;
	short Age;
	
};

int main()
{	
	stEmployee Employee1, *ptr;

	Employee1.FirstName = "Asem";
	Employee1.LastName = "Abu Othman";
	Employee1.Age = 21;

	cout << "Befroe Using Pointer : " << endl;
	cout << Employee1.FirstName << endl;
	cout << Employee1.LastName << endl;
	cout << Employee1.Age << endl;

	cout << endl;

	ptr = &Employee1;

	cout << "After Using Pointer : " << endl;
	cout << ptr->FirstName << endl;
	cout << ptr->LastName << endl;
	cout << ptr->Age << endl;
	
	cout << endl;

	cout << "Address in Memory : " << endl;
	cout << &ptr->FirstName << endl;
	cout << &ptr->LastName << endl;
	cout << &ptr->Age << endl;

	cout << endl;

	return 0;
}
