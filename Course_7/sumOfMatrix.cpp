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

	int matrix[3][3];

	FillArrayWithRandomNumbers(matrix, 3, 3);
	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	cout << "Sum of Matrix 1 : " << SumOfMatrixNumbers(matrix,3,3) << endl;

	return 0;
}