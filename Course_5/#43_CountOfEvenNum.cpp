#include <iostream>
#include <cstdlib>
#include <string>

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

	cout << endl;

	return num;
}

int RandomNum(int from, int to) 
{

	return rand() % (to - from + 1) + from;
}

void FillArrayWithRandomNum(int arr[100], int &arrLength)
{
	arrLength = ReadPositiveNum("Plz enter number of array elements : ");

	for (int i = 0; i < arrLength; i++) 
	{
		arr[i] = RandomNum(1, 100);
	}
}

int CountEvenNumInArray(int arr[100], int arrLength)
{
	int countOfEven = 0;

	for (int i = 0; i < arrLength; i++) 
	{
		if (arr[i] % 2 == 0)
			countOfEven++;
	}

	return countOfEven;
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
	//Seed srand it's call only once
	srand((unsigned)time(NULL));

	// Array is hardcoded
	int arr[100], arrLength = 0;
	
	FillArrayWithRandomNum(arr, arrLength);

	cout << "Array Elements : ";
	PrintArray(arr, arrLength);

	cout << "\nOdd Numbers count is : ";
	cout << CountEvenNumInArray(arr, arrLength);

	cout << endl;

	return 0;
}