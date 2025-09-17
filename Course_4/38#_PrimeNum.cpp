#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enPrimeNotPrime {NotPrime = 0, Prime = 1};

float ReadPositiveNum() 
{
	float num = 0;
	int count = 1;

	do 
	{
		cout << "Enter number to find if prime or not : ";
		cin >> num;
		cout << endl;

	} while (num <= 0);


	cout << endl;

	return num;
}

enPrimeNotPrime CheckPrime(int num) 
{
	int m = round(num / 2);

	for (int count = 2; count <= m; count++) 
	{
		if (num % count == 0)
			return enPrimeNotPrime::NotPrime;
	}

	return enPrimeNotPrime::Prime;
}

void PrintPrimeOrNotPrime(int num) 
{
	cout << "\n";
	cout << "Prime numbers from " << 1 << " To " << num;
	cout << " are: " << endl;

	for (int i =1; i <= num; i++) 
	{
		if (CheckPrime(num) == enPrimeNotPrime::Prime) 
		{
			cout << i << endl;
		}
	}
}

int main()
{
	PrintPrimeOrNotPrime(ReadPositiveNum());

	return 0;
}