/*
Relational Operators	(== , != , >= , <= , >, <)
Assinment Operators		(=, +=, -=, *=, /=, %=)
Arthimatice Opertaors	(+, -, *, / , %)
Logical Operators		(!, &&, || )
*/

#include <iostream>

using namespace std;


int main()
{
	int num1;
	double num2 = 18.6;

	num1 = num2; //implicit conversion
	num1 = (int)num2; //explicit conversion
	num1 = int(num2);//explicit conversion

	cout << num1 << endl;


	return 0;
}