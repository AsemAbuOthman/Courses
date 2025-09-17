#include <iostream>
#include <string>// for getline
#include <vector>

using namespace std;

void Function(int &x) 
{
	x++;

	cout << "\n( x address is " << &x << " )" << endl;
}

int main()
{
	int a = 10;

	cout << "Before edit a value " << endl;
	cout << "---------------------------------------\n" << endl;
	cout << "Value of a is " << a << endl;
	cout << "Address of a is " << &a << endl;
	cout << "\n*--------------------------------------" << endl;

	Function(a);

	cout << "\nAfter edit a value " << endl;
	cout << "---------------------------------------\n" << endl;
	cout << "Value of a is " << a << endl;
	cout << "Address of a is " << &a << endl;
	cout << "\n---------------------------------------" << endl;


	return 0;
}

