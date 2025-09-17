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

int RandomNum(int from, int to)
{
	int randomNum = 0;

	randomNum = rand() % (to - from + 1) + from;

	return randomNum;
}

void FillArrayWithRandomNum(int arr[100], int& length)
{
	length = ReadNum("Plz enter number of elements : ");

	for (int i = 0; i < length; i++)
	{
		arr[i] = RandomNum(1, 100);
	}
}

bool IsOddNum(int num)
{
	return num % 2 == 1;
}

void AddArrayElement(int num ,int arr[100], int &arrLength)
{
	arrLength++;
	arr[arrLength - 1] = num;
}

void CopyOddElements(int arrSource[100], int arrDestination[100], int arrLength, int &arrDestinationLength)
{
	for (int i = 0; i < arrLength; i++) 
	{
		if(IsOddNum(arrSource[i]))
			AddArrayElement(arrSource[i], arrDestination, arrDestinationLength);
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


int main()
{
	srand((unsigned)time(NULL));

	int arr[100], arrLength = 0, arr2Length = 0;
	
	FillArrayWithRandomNum(arr, arrLength);

	int arr2[100];
	CopyOddElements(arr, arr2, arrLength, arr2Length);

	cout << "Array 1 Elements : ";
	PrintArray(arr, arrLength);

	cout << "Array 2 Odd Elements : ";
	PrintArray(arr2, arr2Length);

	cout << endl;

	return 0;
}