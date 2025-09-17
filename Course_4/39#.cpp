#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadPositiveNum(string message) 
{
	int num;

	cout << message;
	cin >> num;

	cout << endl;

	return num;
}

float CalculatePaidBack(float totalBill, float cashPaid) 
{
	float paidBack = cashPaid - totalBill;

	return paidBack;
}


int main()
{
	float totalBill = ReadPositiveNum("Enter total bill : ");
	float cashPaid = ReadPositiveNum("Enter cash paid : ");

	cout << "Total Bill " << totalBill << endl;
	cout << "Cash Paid " << cashPaid << endl;

	cout << "******************\n" << endl;
	cout << "Result is " << CalculatePaidBack(totalBill, cashPaid) << endl;
	
	return 0;
}