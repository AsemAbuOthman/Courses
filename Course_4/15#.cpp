#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(float &num1, float &num2)
{
	cout << "Enter first number  : ";
	cin >> num1;

	cout << "Enter second number : ";
	cin >> num2;

	cout << endl;
}

float CalculateRectangleArea(float num1, float num2) 
{
	return num1 * num2;
}

void PrintResult(float num1, float num2)
{
	cout << "Rectangle area = " << CalculateRectangleArea(num1, num2) << endl;
}



int main()
{
	float num1, num2;
	ReadNum(num1, num2);
	PrintResult(num1, num2);

	return 0;
}