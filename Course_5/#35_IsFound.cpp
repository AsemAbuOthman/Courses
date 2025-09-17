#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int ReadPositiveNum(string message)
{
	int num = 0;

	do 
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num <= 0);

	return num;
}

int RandomNum(int from, int to)
{
	int randNum = 0;

	randNum = rand() % (to - from + 1) + from;
	return randNum;
}

void FillArrayWithRandomNum(int arr[100], int length)
{
	for (int i = 0; i < length; i++) 
	{
		arr[i] = RandomNum(1, 100);
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

int FindNumPositionInArray(int num, int arr[100], int length)
{
	for (int i = 0; i < length; i++) 
	{
		if (num == arr[i])
			return i;
	}

	return -1;
}

bool IsFound(int num, int arr[100], int length)
{
	return FindNumPositionInArray(num, arr, length) != -1;
}

int main()
{
	srand((unsigned)time(NULL));

	int arr[100];
	int	length = ReadPositiveNum("Plz enter number of elements : ");

	FillArrayWithRandomNum(arr, length);
	cout << "Array 1 Elements : ";
	PrintArray(arr,length);

	int numToCheck = ReadPositiveNum("Plz enter a number to search for ? ");
	

	if(IsFound(numToCheck, arr, length);)
	{
		cout << "Number you'r looking for is : ";
		cout << numToCheck;
		cout << "\nYes, The number is found :) \n";
	}
	else
	{
		cout << "Number you'r looking for is : ";
		cout << numToCheck;
		cout << "\nNo, The number is not found :( \n";
	}

	cout << endl;

	return 0;
}