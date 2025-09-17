#include <iostream>
#include <vector>

using namespace std;

void ReadNumber(vector <int> &vNumbers) 
{	
	int number = 0;
	char wantAgain = 'Y';


	do 
	{
		cout << "Plz enter  a number : ";
		cin >> number;

		vNumbers.push_back(number);

		cout << "\n Do you want enter another number ? (Y/N) ? ";
		cin >> wantAgain;

		cout << endl;

	} while (wantAgain == 'Y' || wantAgain == 'y');
}

void PrintNumbers(vector<int> &vNumbers) // Plz call by reference because the won't make a copy (Ton)
{
	cout << "Vector values are : " << endl;
	cout << "******************* " << endl;

	for (int &number : vNumbers) 
	{
		cout << number << endl;
	}
}

int main()
{
	vector<int> vNumbers;
	
	ReadNumber(vNumbers);
	PrintNumbers(vNumbers);

	return 0;
}

