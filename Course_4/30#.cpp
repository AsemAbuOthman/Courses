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
	
	} while (num < 0);

	cout << endl;

	return num;
}

int Factorial(int num) 
{
	int count = 0;
	int fact = 1;

	while (count < num) 
	{
		fact *= (num - count);
		count++;
	}

	return fact;
}

int main()
{	
	cout << Factorial(ReadPositiveNum("Plz enter positive number : ")) << endl;

	return 0;
}