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

void ReadArray(int arr[100], int length)
{

	for (int i = 0; i < length; i++)
	{
		arr[i] = i + 1;
	}
}

int RandomNum(int from, int to) 
{
	int randomNum = 0;
	
	randomNum = rand() % (to - from + 1) + from;

	return randomNum;
}

void FillArrayWithRandomNum(int arr[100], int length)
{
	for (int i = 0; i < length; i++)
	{
		arr[i] = RandomNum(1, 100);
	}
}

void CopyArrayElementsInReverseOrder(int arr1[100], int arr2[100], int length)
{


	for (int i = 0; i < length; i++)
	{
		arr2[i] = arr1[length - 1 - i];
		
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

	int arr1[100], arrInReversedOrder[100];
	int	length = ReadPoaitiveNum("Plz enter number of elements : ");

	FillArrayWithRandomNum(arr1, length);
	cout << "Array 1 Elements :\n";
	PrintArray(arr1, length);

	CopyArrayElementsInReverseOrder(arr1, arrInReversedOrder, length);
	cout << "\nArray 2 Elements after copying array 1 in reversed order :\n";
	PrintArray(arrInReversedOrder, length);


	cout << endl;

	return 0;
}