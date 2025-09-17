#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enOddOrEven {Odd = 1, Even = 2};

int ReadNum()
{
	int num;

	cout << "Plz Enter your num to print from your num to 1 : ";
	cin >> num;

	return num;
}

enOddOrEven CheckOddOrEven(int num) 
{
	if (num % 2 == 0)
		return enOddOrEven::Even;
	else
		return enOddOrEven::Odd;
}

int SumOfOddNumFrom1ToN_UsingFor(int num)
{
	int sum = 0;
	
	for (int count = 1; count <= num; count++) 
	{
		if (CheckOddOrEven(count) == enOddOrEven::Odd)
		{
			sum += count;
		}
	}

	return sum;
}


int SumOfOddNumFrom1ToN_UsingWhile(int num)
{
	int count = 0;
	int sum = 0;

	while (count < num)
	{
		count++;

		if (CheckOddOrEven(count) == enOddOrEven::Odd) 
		{
			sum += count;
		}
	}

	return sum;
}

int SumOfOddNumFrom1ToN_UsingDoWhile(int num)
{
	int count = 0;
	int sum = 0;

	do
	{
		count++;

		if (CheckOddOrEven(count) == enOddOrEven::Odd)
			sum += count;

	} while (count < num);

	return sum;
}


void PrintOddNumRangeFrom1toN_UsingFor(int num, int sum)
{
	for (int i = 1; i <= num; i++)
	{
		if(CheckOddOrEven(i) == enOddOrEven::Odd)
			cout << i << endl;

	}

	cout << "\nSum = " << sum << endl << endl;
}

void PrintOddNumRangeFrom1toN_UsingWhile(int num, int sum)
{
	int count = 0;

	while (count <= num)
	{
		count++;
		if(CheckOddOrEven(count) == enOddOrEven::Odd)
			cout << count << endl;
	}

	cout << "\nSum = " << sum << endl << endl;
}

void PrintOddNumRangeFrom1toN_UsingDoWhile(int num, int sum)
{
	int count = 0;

	do
	{
		count++;

		if(CheckOddOrEven(count) == enOddOrEven::Odd)
			cout << count << endl;

	} while (count <= num);

	cout << "\nSum = " << sum << endl << endl;
}

int main()
{	
	int num = ReadNum();

	PrintOddNumRangeFrom1toN_UsingFor(num, SumOfOddNumFrom1ToN_UsingFor(num));
	PrintOddNumRangeFrom1toN_UsingWhile(num, SumOfOddNumFrom1ToN_UsingWhile(num));
	PrintOddNumRangeFrom1toN_UsingDoWhile(num, SumOfOddNumFrom1ToN_UsingDoWhile(num));

	return 0;
}