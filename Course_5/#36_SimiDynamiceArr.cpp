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

void AddArrayElement(int arr[100], int &length)
{
	length++;
	arr[length - 1] = ReadNum("Plz enter number : ");
}

void InputUserNumInArray(int arr[100], int &length)
{
	bool addMore = true;

	do 
	{
		AddArrayElement(arr, length);
		addMore = ReadNum("Do you want to add more numbers ? [0]:No, [1]:Yes ? ");

	} while(addMore);

	cout << endl;
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
	int arr[100], length = 0;
	
	InputUserNumInArray(arr, length);

	cout << "Array Length: " << length << endl;

	cout << "Array Elements : ";
	PrintArray(arr, length);

	cout << endl;

	return 0;
}