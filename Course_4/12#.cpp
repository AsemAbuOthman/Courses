#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(int &num1, int &num2) 
{
	cout << "Enter number 1 : ";
	cin >> num1;

	cout << "Enter number 2 : ";
	cin >> num2;

	cout << endl;
}

int MaxOf2Numbers(int num1, int num2)
{
	if (num1 > num2)
		return num1;
	else
		return num2;
}

void PrintResults(int maxNum) 
{
	cout << "Maximum number is " << maxNum << endl;
}

int main()
{
	int num1, num2;
	ReadNum(num1, num2);
	PrintResults(MaxOf2Numbers(num1, num2));


	return 0;
}