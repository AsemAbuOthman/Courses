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

short CountNumberInMatrix(int matrix[3][3], short rows, short columns, short number)
{
	short count = 0;

	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix[i][j] == 0)
			{
				count++;
			}
		}
	}

	return count;
}

bool IsSparceMatrix(int matrix[3][3], short rows, short columns)
{
	short matrixSize = rows * columns;


	return CountNumberInMatrix(matrix, rows, columns, 0) > (matrixSize / 2);
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix[3][3] = { {5, 0, 5}, {0, 5, 0}, {0, 0, 5}};
	int number = 5;


	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	if (IsSparceMatrix(matrix, 3, 3)) 
	{
		cout << "Yes : It's Sparce." << endl;
	}
	else
	{
		cout << "No : It's NOT Sparce." << endl;
	}


	return 0;
}