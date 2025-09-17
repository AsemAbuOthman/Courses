#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

// Regular Functions (Without functions overloading) :-( //


int MySum2IntegerNumbers(int num1, int num2) 
{
	return (num1 + num2);
}

int MySum3IntegerNumbers(int num1, int num2, int num3)
{
	return (num1 + num2 + num3);
}

int MySum4IntegerNumbers(int num1, int num2, int num3, int num4)
{
	return (num1 + num2 + num3 + num4);
}

double MySum2DoubleNumbers(double num1, double num2)
{
	return (num1 + num2);
}

double MySum3DoubleNumbers(double num1, double num2, double num3)
{
	return (num1 + num2 + num3);
}

double MySum4DoubleNumbers(double num1, double num2, double num3, double num4)
{
	return (num1 + num2 + num3 + num4);
}


// Functions Overloading :-) //


int MySum(int num1, int num2)
{
	return (num1 + num2);
}

int MySum(int num1, int num2, int num3)
{
	return (num1 + num2 + num3);
}

int MySum(int num1, int num2, int num3, int num4)
{
	return (num1 + num2 + num3 + num4);
}

double MySum(double num1, double num2)
{
	return (num1 + num2);
}

double MySum(double num1, double num2, double num3)
{
	return (num1 + num2 + num3);
}

double MySum(double num1, double num2, double num3, double num4)
{
	return (num1 + num2 + num3 + num4);
}



int main()
{
	// Without function Overloading

	cout << "Wihtout function overloading\n" << endl;

	cout << "****************************" << endl;
	cout << MySum2DoubleNumbers(1.25, 3.5) << endl;
	cout << MySum2IntegerNumbers(1, 2) << endl;
	cout << MySum3DoubleNumbers(1.5, 2.5, 3.5) << endl;
	cout << MySum3IntegerNumbers(1, 2, 3) << endl;
	cout << MySum4DoubleNumbers(1.5, 2.5, 3.5, 4.5) << endl;
	cout << MySum4IntegerNumbers(1, 2, 3, 4) << endl;
	cout << "****************************\n" << endl;


	// Using function Overloading

	cout << "Using function overloading\n" << endl;

	cout << "****************************" << endl;
	cout << MySum(1.25, 3.5) << endl;
	cout << MySum(1, 2) << endl;
	cout << MySum(1.5, 2.5, 3.5) << endl;
	cout << MySum(1, 2, 3) << endl;
	cout << MySum(1.5, 2.5, 3.5, 4.5) << endl;
	cout << MySum(1, 2, 3, 4) << endl;
	cout << "****************************\n" << endl;


	return 0;
}

