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

void Swap(int &A, int &B) 
{
	int temp = A;
	A = B;
	B = temp;
}

void ShuffleArray(int arr[100], int length)
{

	for (int i = 0; i < length; i++) 
	{
		Swap(arr[RandomNum(1, length) - 1], arr[RandomNum(1, length) - 1]);
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

	int arr[100];
	int	length = ReadPoaitiveNum("Plz enter number of elements : ");

	ReadArray(arr, length);
	cout << "Array Elements before shuffle : \n";
	PrintArray(arr, length);

	ShuffleArray(arr, length);
	cout << "\nArray Elements after shuffle: \n";
	PrintArray(arr, length);


	cout << endl;

	return 0;
}