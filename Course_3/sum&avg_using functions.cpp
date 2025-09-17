#include <iostream>
#include <string>

using namespace std;

void ReadArrayData(int arr1[100], int &length)
{
	cout << "How many numbers do you want to enter ? 1 to 100 ? ";
	cin >> length;
	
	for (int i = 0; i < length; i++) 
	{
		cout << "Plz enter number " << i + 1 << " : ";
		cin >> arr1[i];
	}
	cout << endl;
}

void PrintArrayData(int arr1[100], int length)
{
	for (int i = 0; i < length; i++) 
	{
		cout << "Number [" << i + 1 << "] = " << arr1[i] << endl;
	}
	cout << endl;
}

int CalculateSumOfArrayData(int arr1[100], int length)
{
	float sum = 0;

	for (int i = 0; i < length; i++) 
	{
		sum += arr1[i];
	}

	return sum;
}

float CalculateAvgOfArrayData(float sum, int length) 
{
	return sum / length;
}

int main()
{
	int arr1[100];
	int length;

	ReadArrayData(arr1, length);
	PrintArrayData(arr1, length);

	cout << "\n*************************" << endl;
	cout << "\nSum = " << CalculateSumOfArrayData(arr1, length) << endl;
	cout << "\Avg = " << CalculateAvgOfArrayData(CalculateSumOfArrayData(arr1, length), length) << endl;

	return 0;
}