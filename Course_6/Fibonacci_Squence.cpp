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

unsigned long long  MyFibonacciNumbers(short n)
{

	if (n == 1)
		return 1;
	else if (n == 0)
		return 0;

	return  (MyFibonacciNumbers(n - 1) + MyFibonacciNumbers(n - 2));	
}

int main()
{
	short n = ReadPositiveNumber();


	cout << "\nFibonacci squence of " << n << " is : " << MyFibonacciNumbers(n) << endl;

	return 0;
}

