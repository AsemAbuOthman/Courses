#include <iostream>
#include <string>

using namespace std;

enum enNumberType {Odd = 1, Even = 2};

int ReadNumber() 
{
	int num;

	cout << "Enter number to check if it even or odd : ";
	cin >> num;

	return num;
}

enNumberType CheckNumberType(int num) 
{
	int result = num % 2;

	if (result == 0)
		return enNumberType::Even;
	else
		return enNumberType::Odd;

}

void PrintNumberType(enNumberType NumberType) 
{
	if (NumberType == enNumberType::Even) 
	{
		cout << "The number you enterd is Even" << endl;
	}
	else
		cout << "The number you enterd is Odd" << endl;

}


int main()
{
	PrintNumberType(CheckNumberType(ReadNumber()));

	return 0;
}