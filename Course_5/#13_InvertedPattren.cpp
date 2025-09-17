#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enPalindromeNotPalindrome{NotPalindrome= 0, Palindrome = 1};

int ReadPositiveNum(string message)
{
	int num;

	do
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num <= 0);

	cout << endl;

	return num;
}

void PrintInvertedPattren(int num) 
{

	for (int i = num; i >= 1; i--)
	{
		for (int j = 1; j <= i; j++)
		{
			cout << i;
		}
		
		cout << endl;
	}

	cout << endl;
}

int main()
{
	PrintInvertedPattren(ReadPositiveNum("Plz enter number to print inverted pattren : "));

	return 0;
}