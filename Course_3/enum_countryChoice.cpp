#include <iostream>
#include <string>

using namespace std;

enum enCountryChoice {Jordan = 1, USA = 2, Egypt = 3, Maroco = 4, UEA = 5, UK = 6};

int main()
{
	short countryNum;
	enCountryChoice CountryChoice;

	cout << "Choose your country number " << endl;
	cout << "(1) Jordan\n"
		<< "(2) USA\n"
		<< "(3) Egypt\n"
		<< "(4) Maroco\n"
		<< "(5) UEA\n"
		<< "(6) UK" << endl;
	cin >> countryNum;

	CountryChoice = (enCountryChoice)countryNum;

	if (countryNum > 6 || countryNum < 1)
		cout << "Invaild number" << endl;
	else 
	{
		if (CountryChoice == enCountryChoice::Jordan)
			cout << "Your country is Jordan" << endl;
		else if (CountryChoice == enCountryChoice::USA)
			cout << "Your country is USA" << endl;
		else if (CountryChoice == enCountryChoice::Egypt)
			cout << "Your country is Egypt" << endl;
		else if (CountryChoice == enCountryChoice::Maroco)
			cout << "Your country is Maroco" << endl;
		else if (CountryChoice == enCountryChoice::UEA)
			cout << "Your country is UEA" << endl;
		else
			cout << "Your country is UK" << endl;

	}

	return 0;
}