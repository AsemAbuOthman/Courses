#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enPrimeNotPrime { NotPrime = 0, Prime = 1 };

float ReadPositiveNum(string message)
{
	float num = 0;
	int count = 1;

	do
	{
		cout << message;
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

void PrintPrimeFrom1ToN(int num)
{
	cout << "\n";
	cout << "Prime numbers from " << 1 << " To " << num;
	cout << " are: " << endl;

	for (int i = 1; i <= num; i++)
	{
		if (CheckPrime(i) == enPrimeNotPrime::Prime)
		{
			cout << i << endl;
		}
	}
}

int main()
{
	PrintPrimeFrom1ToN(ReadPositiveNum("Enter number : "));

	return 0;
}