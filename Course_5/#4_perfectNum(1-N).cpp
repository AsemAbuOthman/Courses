#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enPerfectNotPerfect {NotPerfect = 0, Perfect = 1};

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


bool IsPerfectNum(int num) 
{
	int sum = 0;

	for (int i = 1; i < num; i++)
	{
		if (num % i == 0)
			sum += i;

	}

	if (sum == num)
		return enPerfectNotPerfect::Perfect;
	else
		return enPerfectNotPerfect::NotPerfect;
}


void PrintPerfecttNumFrom1ToN(int num) 
{
	for (int i = 1; i < num; i++) 
	{
		if (IsPerfectNum(i) == enPerfectNotPerfect::Perfect)
			cout << i << endl;
	}
	cout << endl;
}

int main()
{
	PrintPerfecttNumFrom1ToN(ReadPositiveNum("Plz enter number to print perfect numbers between 1 and your number : "));

	return 0;
}