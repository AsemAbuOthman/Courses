/*
Relational Operators	(== , != , >= , <= , >, <)
Assinment Operators		(=, +=, -=, *=, /=, %=)
Arthimatice Opertaors	(+, -, *, / , %)
Logical Operators		(!, &&, || )
*/

#include <iostream>
#include <string>

using namespace std;

void displayMyCardInfo() 
{
	cout << "***********************" << endl;
	cout << "Name : Asem Abu Othman." << endl;
	cout << "Age : 21" << endl;
	cout << "City : Amman" << endl;
	cout << "Country : Jordan" << endl;
	cout << "***********************" << endl;
	cout << endl;

}

void squareStars() 
{
	cout << "********" << endl;
	cout << "********" << endl;
	cout << "********" << endl;
	cout << "********" << endl;
	cout << endl;

}

void printILoveProgramming() 
{
	cout << "I love programming !\n" << endl;
	cout << "I promise to be the best developer ever!\n" << endl;
	cout << "I know it will take some time, but I will achive my goal\n" << endl;
	cout << "Best Regrads,\nAsem Abu othman";
	cout << endl;

}

void printH() 
{
	cout << "*\t*" << endl;
	cout << "*\t*" << endl;
	cout << "*********" << endl;
	cout << "*\t*" << endl;
	cout << "*\t*" << endl;
	cout << endl;

}

int main()
{

	displayMyCardInfo();
	squareStars();
	printILoveProgramming();
	printH();
	
	
	return 0;
}