#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadNum()
{
	int num;

	cout << "Plz Enter your num to print from 1 to your num : ";
	cin >> num;

	return num;
}

void PrintRangeFrom1ToN_UsingFor(int num) 
{
	for (int i = 1; i <= num; i++) 
	{
		cout << i << endl;
	
	}

	cout << endl;
}

void PrintRangeFrom1ToN_UsingWhile(int num) 
{
	int count = 1;

	while (count <= num) 
	{
		cout << count << endl;
		
		count++;
	}

	cout << endl;
}

void PrintRangeFrom1ToN_UsingDoWhile(int num) 
{
	int count = 1;

	do 
	{
		cout << count << endl;
		count++;

	} while (count <= num);

	cout << endl;
}

int main()
{	

	PrintRangeFrom1ToN_UsingFor(ReadNum());
	PrintRangeFrom1ToN_UsingWhile(ReadNum());
	PrintRangeFrom1ToN_UsingDoWhile(ReadNum());


	return 0;
}