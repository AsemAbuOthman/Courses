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

void PrintFrequencyOfDigit(int num, int digit)
{
	int reminder = 0, sum = 0;


	while (digit > 0)
	{
		reminder = digit % 10;
		digit = digit / 10;

		if (reminder == num)
			sum += 1;
	}

	cout << "Digit " << num << " frequency is " << sum << " Time(s)." << endl;
}

int main()
{
	PrintFrequencyOfDigit(ReadPositiveNum("Plz enter number to find frequency time(s) : "), ReadPositiveNum("Plz enter potitive number : "));



	return 0;
}