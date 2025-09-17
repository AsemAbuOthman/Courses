#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enOperationType {Add = '+', Sub = '-', Mul = '*', Div = '/' };

float ReadNum(string message) 
{
	float num = 0;

	cout << message;
	cin >> num;

	cout << endl;

	return num;
}

enOperationType ReadOperationType() 
{
	char opType = '+';

	cout << "Plz enter operatino (+, -, *, /) : ";
	cin >> opType;

	return (enOperationType)opType;
}

float Calculate(float num1, float num2, enOperationType opType)
{

	switch (opType) 
	{
	case enOperationType::Add:
		return num1 + num2;
	case enOperationType::Sub:
		return num1 - num2;
	case enOperationType::Mul:
		return num1 * num2;
	case enOperationType::Div:
		return num1 / num2;
	defualt:
		return num1 + num2;

	}
}

int main()
{	
	float num1 = ReadNum("Enter first number : ");
	float num2 = ReadNum("Enter second number : ");

	enOperationType opType = ReadOperationType();

	cout << "Result is " << Calculate(num1, num2, opType) << endl;


	return 0;
}