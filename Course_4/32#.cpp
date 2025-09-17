#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadPositiveNum(int &num, int &exp) 
{

	do 
	{
		cout << "Plz enter positive number to find the power of it : ";
		cin >> num;

		cout << "Plz enter positive power : ";
		cin >> exp;

		cout << "**************************" << endl;

	} while (num < 0 || exp < 0);

	cout << endl;
}

int PowerOfNum(int num, int exp) 
{
	if (exp == 0) 
	{
		//Any number powerd to zero gives 1
		return 1;
	}

	int pow = num;

	while (exp > 1) 
	{
		pow *= num;
		exp--;
	}

	return pow;
}

int main()
{	
	int num, exp;
	ReadPositiveNum(num, exp);
	cout << "Result is " << PowerOfNum(num, exp) << endl;

	return 0;
}