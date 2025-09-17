#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(int &num1, int &num2)
{
	cout << "Enter first number  : ";
	cin >> num1;

	cout << "Enter second number : ";
	cin >> num2;

	cout << endl;
}

int Swap(int &num1, int &num2)
{
	int temp = num1;
	num1 = num2;
	num2 = temp;

	return num1;
}

void PrintResults(int num1, int num2)
{
	cout << "num 1 = " << num1 << endl;
	cout << "num 2 = " << num2 << endl;
	cout << endl;
}


int main()
{
	int num1, num2;
	ReadNum(num1, num2);
	PrintResults(num1, num2);
	Swap(num1, num2);
	PrintResults(num1, num2);



	return 0;
}