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

void ReadArray(int arr[100], int &length)
{
	length = ReadNum("Plz enter number of elements : ");

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

int GetMaxElementInArray(int arr[100], int length)
{
	int maxElement = 0;

	for (int i = 0; i < length; i++)
	{
			if (arr[i] > maxElement)
				maxElement = arr[i];
	}

	return maxElement;
}

int SortElementsInArray(int arr[100], int length)
{
	int maxElement = 0;

	for (int i = 0; i < length; i++) 
	{
		for (int j = i; j < length; j++) 
		{
			maxElement = arr[i];

			if (arr[i] > arr[j]) 
			{
				arr[i] = arr[j];
				arr[j] = maxElement;
			}
		
		}
	}

	return arr[100];
}

int main()
{
	srand((unsigned)time(NULL));

	int arr[100], length;

	ReadArray(arr, length);

	cout << "Array Elements : ";
	PrintArray(arr, length);

	cout << "Max Number is : ";
	cout << GetMaxElementInArray(arr, length);

	cout << endl;

	return 0;
}