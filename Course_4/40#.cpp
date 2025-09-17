#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadPositiveNum(string message) 
{
	int num;

	do 
	{
		cout << message;
		cin >> num;

	} while (num <= 0);

	cout << endl;

	return num;
}

float TotalBillAfterServiceAndTax(float totalBill) 
{
	float totalBillAfterServiceAndTax = (totalBill * 1.1) * 1.16;

	return totalBillAfterServiceAndTax;
}


int main()
{
	float totalBill = ReadPositiveNum("Enter total bill : ");

	cout << "Total Bill " << totalBill << endl;

	cout << "******************\n" << endl;
	cout << "Total Bill " << TotalBillAfterServiceAndTax(totalBill) << endl;

	
	return 0;
}