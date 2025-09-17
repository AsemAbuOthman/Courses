#include <iostream>
#include <string>

using namespace std;

int main()
{
	float num1, num2;
	string operation;

	cout << "Plz enter number 1 : ";
	cin >> num1;

	cout << "Plz enter number 2 : ";
	cin >> num2;

	cout << "Enter the operation (+, -, /, *) : ";
	cin >> operation;

	if (operation == "+")
		cout << num1 + num2 << endl;
	else if (operation == "-")
		cout << num1 - num2 << endl;
	else if (operation == "*")
		cout << num1 * num2 << endl;
	else
		cout << num1 / num2 << endl;



	return 0;
}