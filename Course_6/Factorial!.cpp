#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

#include "MyValiditionLib.h";

using namespace std;

int ReadPositiveNumber()
{
	int number = 0;

	do 
	{
		number = MyValidLib::ReadNum("Plz enter a positive number : ");

	} while (number <= 0); 

	return number;
}

unsigned long long  MyFactorial(short n)
{
	if (n == 0)
		return 1;

	return n * MyFactorial(n - 1);
}

int main()
{
	short n = ReadPositiveNumber();


	cout << "\Factorial of " << n << " is : " << MyFactorial(n) << endl;

	return 0;
}

