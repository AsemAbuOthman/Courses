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

short GetNumberOfElement(int matrix[3][3], short rows, short columns, short number)
{
	short count = 0;

	for (short i = 0; i < rows; i++)
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix[i][j] == number) 
			{
				count++;
			}
		}
	}

	return count;
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix[3][3] = { {5, 0, 5}, {0, 5, 5}, {0, 5, 5}};
	int number = 5;


	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	cout << "Count of " << number << " is " << GetNumberOfElement(matrix, 3, 3, number) << endl;


	return 0;
}