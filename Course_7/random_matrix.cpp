#include <iostream>
#include <string>
#include <cstdlib>
#include <iomanip>

using namespace std;

void Tab(short numberOfTabs) 
{
	for (int i = 1; i <= numberOfTabs; i++) 
	{
		cout << "\t";
	}
}

int RandomNumber(int from, int to) 
{
	int randomNum;
	randomNum = rand() % (to - from + 1) + from;

	return randomNum;
}

void FillArrayWithRandomNumbers(int matrix[3][3])
{
	for (int i = 0; i < 3; i++) 
	{
		for (int j = 0; j < 3; j++) 
		{
			matrix[i][j] = RandomNumber(1, 100);
		}	
	}
}

void PrintArrayNumbers(int matrix[3][3])
{
	cout << "The following is a 3x3 random matrix: " << endl;

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++) 
		{
			cout << matrix[i][j];
			Tab(1);
		}
		cout << endl;
	}
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix[3][3];
	FillArrayWithRandomNumbers(matrix);
	PrintArrayNumbers(matrix);

	cout << endl;

	cout << setw(3) << 1 << endl;

	return 0;
}