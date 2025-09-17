#include <iostream>
#include<cstdlib>
#include <iomanip>
#include <cmath>

using namespace std;

void PrintArrayNumbers(int matrix[3][3], short rows, short columns)
{
	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			cout << setw(2) << matrix[i][j];
			cout << "\t";
		}
		cout << endl;
	}
}


bool IsNumber(int matrix1[3][3],int number, short rows, short columns)
{	

	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix1[i][j] == number)
				return true;
		}
	}

	return false;
}

void IntersectedNumbersInMatrix(int matrix1[3][3], int matrix2[3][3], short rows, short columns)
{
	cout << "Intersected Numbers are : \n" << endl;

	int number;

	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			number = matrix2[i][j];

			if (IsNumber(matrix1, number, rows, columns))
			{
				cout << setw(3) << number << "\t";

			}

		}

	}
}


int main()
{
	srand((unsigned)time(NULL));

	int matrix1[3][3] = { {77, 5, 12}, {22, 20, 1}, {1, 0, 9}};
	int matrix2[3][3] = { {5, 80, 90}, {22, 77, 1}, {10, 8, 33} };


	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix1, 3, 3);

	cout << endl;


	cout << "Matrix 2 : " << endl;
	PrintArrayNumbers(matrix2, 3, 3);

	cout << endl;

	IntersectedNumbersInMatrix(matrix1, matrix2, 3, 3);

	return 0;
}