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

//void FillArrayWithOrderedNumbers(int matrix[3][3], short rows, short columns)
//{
//	short counter = 0;
//
//	for (short i = 0; i < rows; i++)
//	{
//		for (short j = 0; j < columns; j++)
//		{
//			matrix[i][j] = ++counter;
//		}
//	}
//}

//void TransposeMatrix(int matrix[3][3], int transposedMatrix[3][3], short rows, short columns)
//{
//
//	for (short i = 0; i < rows; i++)
//	{
//		for (short j = 0; j < columns; j++)
//		{
//			transposedMatrix[j][i] = matrix[i][j];
//		}
//	}
//}

void MiddleRowOfMatrix(int matrix[3][3],int resultMatrix[3], short rows, short columns)
{
	short positionOfMiddleRow = ceil(rows / 2);

	for (int i = 0; i < columns; i++)
	{
		resultMatrix[i] = matrix[positionOfMiddleRow][i];

	}

}

void MiddleColumnOfMatrix(int matrix[3][3], int resultMatrix[3], short rows, short columns)
{
	short positionOfMiddleRow = ceil(rows / 2);

	for (int i = 0; i < rows; i++)
	{
		resultMatrix[i] = matrix[i][positionOfMiddleRow];

	}

}

void PrintRowOrColumnOfMatrix(int resultMatrix[3], short rows)
{
	for (short i = 0; i < rows; i++) 
	{
		cout << setw(2);
		printf(" %0*d", 2, resultMatrix[i]);
		cout << "\t";
	}
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

//
//int ColumnsSum(int matrix[3][3],short rows, short column)
//{
//	int sum = 0;
//
//	for (int i = 0; i < rows; i++)
//	{
//		sum += matrix[i][column];
//	}
//
//	return sum;
//}


//void PrintSumColumns(int matrix[3][3], short rows, short columns)
//{
//	int sumMatrix[3];
//
//	for (int i = 0; i < rows; i++) 
//	{
//		cout << " Columns " << i + 1 << " Sum = " << ColumnsSum(matrix, rows, i) << endl;
//	}
//}

int main()
{
	//srand((unsigned)time(NULL));

	int matrix1[3][3], resultMatrix[3];

	FillArrayWithRandomNumbers(matrix1, 3, 3);
	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix1, 3, 3);

	cout << endl;

	//TransposeMatrix(matrix, transposedMatrix, 3, 3);
	MiddleRowOfMatrix(matrix1, resultMatrix, 3, 3);
	cout << "Middle Row of Matrix 1 : " << endl;
	PrintRowOrColumnOfMatrix(resultMatrix, 3);

	cout << endl << endl;

	MiddleColumnOfMatrix(matrix1, resultMatrix, 3, 3);
	cout << "Middle Column of Matrix 1 : " << endl;
	PrintRowOrColumnOfMatrix(resultMatrix, 3);

	cout << endl;

	return 0;
}