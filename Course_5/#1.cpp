#include <iostream>
#include <string>
#include <cmath>

using namespace std;


void PrintTableHeader() 
{
		cout << "\n\t\t\tMultipliaction Table From 1 to 10" << endl << endl;
		cout << "\t";

		for (int i = 1; i <= 10; i++) 
		{
			cout << i << "\t";
		}

		cout << "\n-----------------------------------------"
			<< "------------------------------------------" << endl;
}


string ColumnSpreator(int i)
{
	if (i < 10)
		return "  |";
	else
		return " |";
}

void PrintMultipilcatoinTableFrom() 
{
	PrintTableHeader();

	for (int i = 1; i <= 10; i++) 
	{
		cout << " " << i << ColumnSpreator(i) << "\t";
		
		for (int j = 1; j <= 10; j++) 
		{
			cout << i * j << " \t";
		}
		cout << endl;
	}
}

int main()
{
	PrintMultipilcatoinTableFrom();

	return 0;
}