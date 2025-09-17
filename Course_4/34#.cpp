#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadPositiveNum() 
{
	int totalSales;

	cout << "Plz enter your total sales : ";
	cin >> totalSales;

	cout << "**************************" << endl;


	cout << endl;

	return totalSales;
}

float GetCommissionPrecentage(int totalSales)
{
	if (totalSales > 1e6)
		return 1e-2;
	else if (totalSales > 5e5)
		return 2e-2;
	else if (totalSales > 1e5)
		return 3e-2;
	else if (totalSales > 5e4)
		return 5e-2;
	else
		return 1;
}

int CalculateTotalSalesAfterCommission(int totalSales)
{

	return GetCommissionPrecentage(totalSales) * totalSales;
}


int main()
{	

	cout << CalculateTotalSalesAfterCommission(ReadPositiveNum()) << endl;

	return 0;
}