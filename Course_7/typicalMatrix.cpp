#include <iostream>
#include<cstdlib>
#include <iomanip>
#include <cmath>

using namespace std;

int RandomNumber(int from, int to) 
{
	int randomNumber;

	randomNumber = rand() % (to - from + 1) + from;

	return randomNumber;
}

void FillArrayWithRandomNumbers(int matrix[3][3], short rows, short columns)
{
	for (int i = 0; i < rows; i++) 
	{
		for (int j = 0; j < columns; j++) 
		{
			matrix[i][j] = RandomNumber(1, 10);
		}
	}
}

string CheckMatrixEquality(int matrix1[3][3], int matrix2[3][3], short rows, short columns)
{

	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix1[i][j] != matrix2[i][j]) 
			{
				return "No : matrcies are NOT equal.\n";
			}	
		}
	}

	return "Yes : matrcies are equal.";
}

void PrintArrayNumbers(int matrix[3][3], short rows, short columns)
{
	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			cout << setw(2);
			printf(" %0*d", 2, matrix[i][j]);
			cout << "\t";
		}
		cout << endl;
	}
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix1[3][3], matrix2[3][3];

	FillArrayWithRandomNumbers(matrix1, 3, 3);
	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix1, 3, 3);

	cout << endl;

	FillArrayWithRandomNumbers(matrix2, 3, 3);
	cout << "Matrix 2 : " << endl;
	PrintArrayNumbers(matrix2, 3, 3);

	cout << endl;

	cout << CheckMatrixEquality(matrix1, matrix2, 3, 3) << endl;


	return 0;
}