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
			matrix[i][j] = RandomNumber(1, 10);
		}
	}
}
//
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
//	int tempRowMatrix[3][3];
//	int tempColumnMatrix[3][3];
//
//	
//
//	for (short i = 0; i < rows; i++)
//	{
//		for (short j = 0; j < columns; j++)
//		{
//			transposedMatrix[j][i] = matrix[i][j];
//		}
//	}
//}

void FillArrayWithMultiplyTwoMatrix(int resultMatrix[3][3], int matrix1[3][3], int matrix2[3][3], short rows, short columns)
{
	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns; j++)
		{
			resultMatrix[i][j] = matrix1[i][j] * matrix2[i][j];
		}
	}
}

void PrintArrayNumbers(int matrix[3][3], short rows, short columns)
{
	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			cout << setw(3) << matrix[i][j] << "\t";
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

	int matrix1[3][3], matrix2[3][3], resultMatrix[3][3];

	FillArrayWithRandomNumbers(matrix1, 3, 3);
	cout << "The following is a 3x3 random matrix1 : " << endl;
	PrintArrayNumbers(matrix1, 3, 3);

	cout << endl;

	FillArrayWithRandomNumbers(matrix2, 3, 3);
	cout << "The following is a 3x3 random matrix2 : " << endl;
	PrintArrayNumbers(matrix2, 3, 3);


	cout << endl;

	FillArrayWithMultiplyTwoMatrix(resultMatrix, matrix1, matrix2, 3, 3);
	cout << "Result : " << endl;
	PrintArrayNumbers(resultMatrix, 3, 3);

	return 0;
}