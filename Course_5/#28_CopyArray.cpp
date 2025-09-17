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

void CopyArrayElements(int arr1[100],int arr2[100], int length)
{

	for (int i = 0; i < length; i++) 
	{
		arr2[i] = arr1[i];

	}

}

int main()
{
	srand((unsigned)time(NULL));

	int arr1[100], length;

	ReadArray(arr1, length);

	cout << "Array 1 Elements : \n";
	PrintArray(arr1, length);

	int arr2[100];
	CopyArrayElements(arr1, arr2, length);

	cout << "\nArray 2 Elements : \n";
	PrintArray(arr2, length);

	cout << endl;

	return 0;
}