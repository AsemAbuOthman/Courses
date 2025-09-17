#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

void FillArray(int arr[100], int &length)
{
	length = 5;
	
	arr[0] = 10;
	arr[1] = 20;
	arr[2] = 30;
	arr[3] = 20;
	arr[4] = 20;
}

void PrintArray(int arr[100], int length)
{
	for (int i = 0; i < length; i++) 
	{
		cout << arr[i] << " ";
	}

	cout << endl;
}

bool IsArrayPalindrome(int arr[100], int length) 
{
	for (int i = 0; i < length; i++) 
	{
		if (arr[i] != arr[length - i - 1])
		{
			return false;
		}
	}

	return true;
}

int main()
{
	// Array is hardcoded
	int arr[100], arrLength = 0;
	
	FillArray(arr, arrLength);

	if (IsArrayPalindrome(arr, arrLength))
		cout << "Yes, Array is Palindrome. " << endl;
	else
		cout << "No, Array is not Palindrome. " << endl;

	cout << endl;

	return 0;
}