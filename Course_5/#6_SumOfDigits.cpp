#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadPositiveNum(string message) 
{
	int num;

	do 
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num <= 0);

	cout << endl;

	return num;
}

void PrintSumOfDigits(int num) 
{
	int reminder = 0;
	int sum = 0;

	while (num > 0) 
	{
		reminder = num % 10;
		num = num / 10;

		sum += reminder;
	}

	cout << "Sum of digits = " << sum << endl;
}

int main()
{
	PrintSumOfDigits(ReadPositiveNum("Plz enter potitive number : "));

	return 0;
}