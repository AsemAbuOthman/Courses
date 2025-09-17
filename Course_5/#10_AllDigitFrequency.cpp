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

int CountDigitFrequency(int num, int digit)
{
	int reminder = 0, sum = 0;


	while (num > 0)
	{
		reminder = num % 10;
		num = num / 10;

		if (reminder == digit)
			sum += 1;
	}

	return sum;
}

void PrintAllDigitsFrequency(int num) 
{

	for (int i = 1; i < 10; i++) 
	{
		short digitFrequency = 0;
		digitFrequency = CountDigitFrequency(num, i);

		if (digitFrequency > 0) 
		{
			cout << "Digit " << i << " freqency is " << digitFrequency << " Time(s)." << endl;
		}
	}
}

int main()
{
	PrintAllDigitsFrequency(ReadPositiveNum("Plz enter number to find frequency time(s) : "));



	return 0;
}