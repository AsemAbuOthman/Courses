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

bool IsMatrixIdentity(int matrix[3][3], short rows, short columns)
{

	for (short i = 0; i < rows; i++) 
	{

		for (short j = 0; j < columns; j++)
		{	

				if (i == j && matrix[i][j] != 1)
				{
					return false;
				}
				else if(i != j && matrix[i][j] != 0)
				{
					return false;
				}

		}
	}

	return true;
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix[3][3] = { {1, 0, 0}, {0, 1, 0}, {0, 0, 1} };
	
	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	if (IsMatrixIdentity(matrix, 3, 3)) 
	{
		cout << "Yes : Matrix is identity." << endl;
	}
	else
	{
		cout << "No : Matrix is not identity." << endl;
	}


	return 0;
}