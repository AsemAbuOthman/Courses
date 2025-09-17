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

int ReverseNum(int num) 
{
	int reverseNum = 0, reminder = 0;

	while(num > 0) 
	{
		reminder = num % 10;
		num = num / 10;

		reverseNum = reverseNum * 10 + reminder;
	}

	return reverseNum;
}

void PrintDigits(int num) 
{
	int reminder = 0;

	while (num > 0) 
	{
		reminder = num % 10;
		num = num / 10;

		cout << reminder << endl;
	}
}

int main()
{
	PrintDigits(ReverseNum(ReadPositiveNum("Plz enter positive numebr : ")));

	return 0;
}