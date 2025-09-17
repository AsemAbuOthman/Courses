#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int ReadPoaitiveNum(string message) 
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
	int randomNum = 0;
	
	randomNum = rand() % (to - from + 1) + from;

	return randomNum;
}

void ReadArray(int arr[100], int length)
{


	for (int i = 0; i < length; i++) 
	{
		arr[i] = RandomNum(1, 100);
	}
}



void CopyArrayElements(int arr1[100], int arr2[100],int sumOfArrays[100], int length)
{
	int sum = 0;

	for (int i = 0; i < length; i++) 
	{
		sumOfArrays[i] = arr1[i] + arr2[i];
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

	int arr1[100], arr2[100], sumOfArrays[100];
	int	length = ReadPoaitiveNum("Plz enter number of elements : ");

	ReadArray(arr1, length);
	cout << "Array 1 Elements : \n";
	PrintArray(arr1, length);

	ReadArray(arr2, length);
	cout << "\nArray 2 Elements : \n";
	PrintArray(arr2, length);

	cout << "\n\nSum of array1 and array2 elements : ";
	CopyArrayElements(arr1,arr2, sumOfArrays, length);
	PrintArray(sumOfArrays, length);

	cout << endl;

	return 0;
}