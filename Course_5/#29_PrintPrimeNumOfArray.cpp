#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

enum enPrimeNotPrime {NotPrime = 0, Prime = 1};

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

void ReadArray(int arr[100], int &length)
{
	length = ReadPoaitiveNum("Plz enter number of elements : ");

	for (int i = 0; i < length; i++) 
	{
		arr[i] = RandomNum(1, 100);
	}
}

bool IsPrimeNum(int num)
{

	for (int i = 2; i < num; i++)
	{
		if (num % i == 0)
			return enPrimeNotPrime::NotPrime;
	}

	return enPrimeNotPrime::Prime;
}

void CopyArrayElements(int arr1[100], int arr2[100], int length1, int &length2)
{
	int count = 0;

	for (int i = 0; i < length1; i++)
	{
		if (IsPrimeNum(arr1[i]))
		{
			arr2[count] = arr1[i];
			count++;
		}

	}

	length2 = count; 
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

	int arr1[100], length1, length2;

	ReadArray(arr1, length1);

	cout << "Array 1 Elements : \n";
	PrintArray(arr1, length1);

	int arr2[100];
	CopyArrayElements(arr1, arr2, length1, length2);

	cout << "\nPrime number in Array 2 : \n";
	PrintArray(arr2, length2);

	cout << endl;

	return 0;
}