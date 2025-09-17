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

bool IsPalindromMatrix(int matrix[3][3], short rows, short columns)
{
	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns / 2; j++) 
		{
			if (matrix[i][j] != matrix[i][columns - j - 1])
			{
				return false;
			}
		}
	}

	return true;
}

int main()
{

	int matrix[3][3] = { {1, 2, 1}, {5, 1, 5}, {7, 3, 7} };

	cout << "Matrix : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	if (IsPalindromMatrix(matrix, 3, 3)) 
	{
		cout << "Yes : Matrix is palindrome" << endl;
	}
	else
	{
		cout << "No : Matrix is NOT palindrome" << endl;
	}

	return 0;
}