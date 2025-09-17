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

int GetMaxNumberInMatrix(int matrix[3][3], short rows, short columns)
{
	int max = matrix[0][0];

	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix[i][j] > max)
			{
				max = matrix[i][j];
			}
		}
	}

	return max;
}

int GetMinNumberInMatrix(int matrix[3][3], short rows, short columns)
{
	int min = matrix[0][0];

	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix[i][j] < min)
			{
				min = matrix[i][j];
			}
		}
	}

	return min;
}

int main()
{

	int matrix[3][3] = { {77, 5, 12}, {22, 20, 1}, {1, 0, 9}};

	cout << "Matrix : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	cout << "Maximum number in matrix is : " << GetMaxNumberInMatrix(matrix, 3, 3) << endl;
	cout << "Minimum number in matrix is : " << GetMinNumberInMatrix(matrix, 3, 3) << endl;

	return 0;
}