#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int ReadNum() 
{
	int number = 0;

	cout << "Please enter a number ? ";
	cin >> number;

	while (cin.fail()) 
	{
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');

		cout << "Invalid Number, Enter a valid one: ";
		cin >> number;
	
	}

	return number;
}

int main()
{

	cout << "Your number is : " << ReadNum();


	return 0;
}
