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
	string myString = "ANCDEFGHIJKLMNOPQRSTUVWXYZ";
	cout << "The length of the myString " << myString.length() << endl;
	
	cout << myString[2] << endl;// will print C

	string s1 = "10", s2 = "20";
	string s3 = s1 + s2;

	cout << "The s3 is " << s3 << endl;// will print 1020
	
	int sum = stoi(s1) + stoi(s2);
	cout << "The sum is " << sum << endl;// will print 30


	return 0;
}