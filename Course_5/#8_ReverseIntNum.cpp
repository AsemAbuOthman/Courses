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

void PrintReverseOfDigits(int num) 
{
	int reminder = 0;
	int reverseNum = 0;

	while (num > 0) 
	{
		reminder = num % 10;
		num = num / 10;

		reverseNum = reverseNum * 10 + reminder;
	}

	cout << "Reverse is " << reverseNum << endl;
}

int main()
{
	PrintReverseOfDigits(ReadPositiveNum("Plz enter potitive number : "));


	return 0;
}