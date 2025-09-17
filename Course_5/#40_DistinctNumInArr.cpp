#include <iostream>
#include <cstdlib>
#include <string>

using namespace std;

void AddArrayElement(int num ,int arr[100], int &arrLength)
{
	arrLength++;
	arr[arrLength - 1] = num;
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

bool IsNumInArray(int num, int arr[100], int length)
{
	return FindNumPositionInArray(num, arr, length) != -1;
}

void CopyDistinctElements(int arrSource[100], int arrDestination[100], int arrLength, int &arrDestinationLength)
{
	for (int i = 0; i < arrLength; i++) 
	{
	if(!IsNumInArray(arrSource[i], arrDestination, arrLength))
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
	// Array is hardcoded
	int arr[] = {10, 10, 10, 50, 50, 70, 70, 70, 70, 90}, arrLength = 0, arr2Length = 0;

	arrLength = sizeof(arr) / sizeof(arr[0]);

	int arr2[100];
	CopyDistinctElements(arr, arr2, arrLength, arr2Length);

	cout << "Array 1 Elements : ";
	PrintArray(arr, arrLength);

	cout << "Array 2 distinct Elements : ";
	PrintArray(arr2, arr2Length);

	cout << endl;

	return 0;
}