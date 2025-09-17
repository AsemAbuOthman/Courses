#include <iostream>
#include <string>

using namespace std;

void ReadNumbers(int &num1, int &num2, int &num3) 
{
	cout << "Enter first number : ";
	cin >> num1;

	cout << "Enter second number : ";
	cin >> num2;

	cout << "Enter thrid number : ";
	cin >> num3;

	cout << endl;
}

int SumOf3Numbers(int num1, int num2, int num3) 
{
	return num1 + num2 + num3;
}

void PrintSumOf3Numbers(int num1, int num2, int num3) 
{
	cout << num1 << " + " << num2 << " + " << num3 << " = " << SumOf3Numbers(num1,num2,num3) << endl;
}


int main()
{
	int num1, num2, num3;
	ReadNumbers(num1, num2, num3);
	PrintSumOf3Numbers(num1, num2, num3);


	return 0;
}