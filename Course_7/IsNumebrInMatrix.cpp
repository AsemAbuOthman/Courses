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

short ReadNumber(string message)
{
	short number;

	cout << message;
	cin >> number;

	return number;
}

bool IsNumberInMatrix(int matrix[3][3], short rows, short columns)
{	
	short number = ReadNumber("Plz enter the  number you  want to search on it ? ");

	for (short i = 0; i < rows; i++) 
	{
		for (short j = 0; j < columns; j++)
		{
			if (matrix[i][j] == number)
				return true;
		}
	}

	return false;
}

int main()
{
	srand((unsigned)time(NULL));

	int matrix[3][3] = { {77, 5, 12}, {22, 20, 1}, {1, 0, 9}};


	cout << "Matrix 1 : " << endl;
	PrintArrayNumbers(matrix, 3, 3);

	cout << endl;

	if (IsNumberInMatrix(matrix, 3, 3))
	{
		cout << "Yes : it's there" << endl;
	}
	else
	{
		cout << "No : it's NOT there" << endl;
	}

	return 0;
}