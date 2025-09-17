#include <iostream>
#include<cstdlib>
#include <iomanip>

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
			matrix[i][j] = RandomNumber(1, 100);
		}
	}
}

void PrintArrayNumbers(int matrix[3][3], short rows, short columns)
{
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			cout << setw(3)  << matrix[i][j] << "\t";
		}
		cout << endl;
	}
}

int SumOfArrayColumnsInRow(int matrix[3][3],short row, short columns)
{
	int sum = 0;

	for (int i = 0; i < columns; i++) 
	{
		sum += matrix[row][i];
	}

	return sum;
}

void FillArrayWithSumValues(int sumMatrix[3], int matrix[3][3], short rows, short columns)
{
	for (int i = 0; i < rows; i++) 
	{
		sumMatrix[i] = SumOfArrayColumnsInRow(matrix, i, columns);
	}
}

void PrintSumOfArrayColumns(int matrix[3][3], short rows, short columns)
{
	int sumMatrix[3];

	FillArrayWithSumValues(sumMatrix, matrix, rows, columns);

	for (int i = 0; i < rows; i++) 
	{
		cout << " Row " << i + 1 << " Sum = " << sumMatrix[i] << endl;
	}
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix[3][3];

	FillArrayWithRandomNumbers(matrix, 3, 3);
	cout << "The following is a 3x3 random matrix : " << endl;
	PrintArrayNumbers(matrix, 3, 3);
	
	cout << endl;

	cout << "The following are the sum of each row in the matrix : " << endl;
	PrintSumOfArrayColumns(matrix, 3, 3);

	return 0;
}