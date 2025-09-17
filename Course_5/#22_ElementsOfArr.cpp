#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int ReadNum(string message) 
{
	int num = 0;

	do 
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num < 0);


	return num;
}

void ReadArray(int arr[100], int &length)
{
	length = ReadNum("Plz enter number of elements : ");

	for (int i = 0; i < length; i++) 
	{
		arr[i] = ReadNum("Element[" + to_string(i + 1) + "]: ");
	}
}

void PrintArray(int arr[100], int length)
{
	for (int i = 0; i < length; i++) 
	{
		cout << arr[i] << " ";
	}

	cout << endl;
}

int TimesRepeated(int numToCheck, int arr[100], int length)
{
	int count = 0;

	for (int i = 0; i < length; i++) 
	{
		if (numToCheck == arr[i])
			count++;
	}

	return count;
}

int main()
{
	int arr[100], numToCheck, length;

	ReadArray(arr, length);

	numToCheck = ReadNum("Enter the number you want to check: ");

	cout << "Orginal array: ";
	PrintArray(arr, length);

	cout << "Number " << numToCheck;
	cout << " is repeated " << TimesRepeated(numToCheck, arr, length) << " Time(s).\n";

	return 0;
}