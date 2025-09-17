/*
Relational Operators	(== , != , >= , <= , >, <)
Assinment Operators		(=, +=, -=, *=, /=, %=)
Arthimatice Opertaors	(+, -, *, / , %)
Logical Operators		(!, &&, || )
*/

#include <iostream>
#include <string>

using namespace std;


int main()
{
	string str1 = "43.22";
	int n1 = 20;
	double n2 = 33.5;
	float n3 = 55.23;

	//conversion string to nums
	double str_double = stod(str1);
	float str_float = stof(str1);
	int str_int = stoi(str1);

	//conversion nums to string
	string int_str = to_string(n1);
	string double_str = to_string(n2);
	string float_str = to_string(n3);

	//conversion float to int using three ways
	int float_int1 = n3;
	int float_int2 = (int) n3;
	int float_int3 = int(n3);


	return 0;
}