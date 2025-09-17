#include <iostream>
#include <string>
#include <cmath>

using namespace std;

struct stPiggyBankContent
{
	int Pennies, Nickels, Dimes, Quarters, Dollars;
};

stPiggyBankContent ReadPiggyBankContent() 
{
	stPiggyBankContent PiggyBankContent;

	cout << "Enter pennies : ";
	cin >> PiggyBankContent.Pennies;

	cout << "\nEnter Nickels : ";
	cin >> PiggyBankContent.Nickels;

	cout << "\nEnter Dimes : ";
	cin >> PiggyBankContent.Dimes;

	cout << "\nEnter Quarters : ";
	cin >> PiggyBankContent.Quarters;

	cout << "\nEnter Dollars : ";
	cin >> PiggyBankContent.Dollars;

	cout << endl;

	return PiggyBankContent;
}

int CalculatTotalPennies(stPiggyBankContent PiggyBankContent)
{
	int totalPennies = PiggyBankContent.Pennies + (PiggyBankContent.Nickels * 5) +
		(PiggyBankContent.Dimes * 10) +(PiggyBankContent.Quarters * 25) + 
		(PiggyBankContent.Dollars * 100);

	return  totalPennies;
}

int main()
{	
	int totalPennies = CalculatTotalPennies(ReadPiggyBankContent());

	cout << "Total pennies are " << totalPennies << endl;
	cout << "Total dollars are " << (float)totalPennies / 100 << endl;

	return 0;
}