#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(int &num1, int &num2, int &num3)
{
	cout << "Enter number 1 : ";
	cin >> num1;

	cout << "Enter number 2 : ";
	cin >> num2;

	cout << "Enter number 3 : ";
	cin >> num3;

	cout << endl;
}

int MaxOf3Numbers(int num1, int num2, int num3)
{
	if (num1 > num2 && num1 > num3)
		return num1;
	else if (num2 > num1 && num2 > num3)
		return num2;
	else
		return num3;
}

void PrintResults(int maxNum) 
{
	cout << "Maximum number is " << maxNum << endl;
}

int main()
{
	int num1, num2, num3;
	ReadNum(num1, num2, num3);
	PrintResults(MaxOf3Numbers(num1, num2, num3));


	return 0;
}