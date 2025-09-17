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

int SumOfMatrixNumbers(int matrix[3][3], short rows, short columns)
{
	int sum = 0;

	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns; j++)
		{
			sum += matrix[i][j];
		}
	}

	return sum;
}

bool AreMatrciesEquvelant(int matrix1[3][3], int matrix2[3][3], short rows, short columns)
{
	return (SumOfMatrixNumbers(matrix1, rows, columns) == SumOfMatrixNumbers(matrix2, rows, columns));
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

	if (AreMatrciesEquvelant(matrix1, matrix2, 3, 3))
	{
		cout << "Yes : matrcies are equal." << endl;

	}
	else
	{
		cout << "No : matrcies are NOT equal." << endl;

	}

	return 0;
}