#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadNum()
{
	int num;

	cout << "Plz Enter your num to print from your num to 1 : ";
	cin >> num;

	return num;
}

void PrintRangeFromNto1_UsingFor(int num) 
{
	for (int i = num; i >= 1; i--)
	{
		cout << i << endl;
	
	}

	cout << endl;
}

void PrintRangeFromNto1_UsingWhile(int num) 
{
	int count = num;

	while (count >= 1)
	{
		cout << count << endl;
		
		count--;
	}

	cout << endl;
}

void PrintRangeFromNto1_UsingDoWhile(int num) 
{
	int count = num;

	do 
	{
		cout << count << endl;
		count--;

	} while (count >= 1);

	cout << endl;
}

int main()
{	

	PrintRangeFromNto1_UsingFor(ReadNum());
	PrintRangeFromNto1_UsingWhile(ReadNum());
	PrintRangeFromNto1_UsingDoWhile(ReadNum());


	return 0;
}