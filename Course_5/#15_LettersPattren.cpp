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


void PrintLettersPattren(int num)
{
	for (int i = 65; i <= (num + 65 - 1); i++)
	{
		for (int j = i; j >= 65; j--)
		{
			cout << char(i);
		}

		cout << endl;
	}
}


int main()
{
	PrintLettersPattren(ReadPositiveNum("Plz enter number to print inverted letters : "));

	return 0;
}