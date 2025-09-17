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

int ReverseNum(int num)
{
	int reminder = 0, reverseNum = 0;

	while (num > 0) 
	{
		reminder = num % 10;
		num = num / 10;

		reverseNum = reverseNum * 10 + reminder;
	}

	return reverseNum;
}

bool IsPalindromeNum(int num) 
{
	int num2 = ReverseNum(num);

	if (num == num2)
		return enPalindromeNotPalindrome::Palindrome;
	else
		return enPalindromeNotPalindrome::NotPalindrome;
}

void PrintMessage(int num) 
{
	if(IsPalindromeNum(num))
		cout << "Yes, it's a Palindrome number." << endl;
	else
		cout << "No, it's NOT a Palindrome number." << endl;
}

int main()
{
	PrintMessage(ReverseNum(ReadPositiveNum("Plz enter number to check if palindrome number or not : ")));

	return 0;
}