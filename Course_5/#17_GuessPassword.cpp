#include <iostream>
#include <string>
#include <cmath>

using namespace std;


string ReadPassword(string message)
{
	string password = "";

	do
	{
		cout << message;
		cin >> password;
		cout << endl;

		if (password < "AAA" || password > "ZZZ")
			cout << "Plz try again\n" << "***********************" << endl;

	} while (password < "AAA" || password > "ZZZ");

	cout << endl;

	return password;
}


bool GuessPassword(string password)
{
	string word = "";
	int count = 0;

	for (int i = 65; i <= 90; i++)
	{
		for (int j = 65; j <= 90; j++)
		{	
			for (int k = 65; k <= 90; k++) 
			{
				word += char(i);
				word += char(j);
				word += char(k);

				count++;

				cout << "Trial[" << count << "]:" << word << endl;

				if (word == password) 
				{
					cout << "\nPassword is " << password << endl;
					cout << "Found after " << count << " Trial(s)" << endl;
					
					return true;
				}

				word = "";
			}
		}

	}

}


int main()
{
	GuessPassword(ReadPassword("Plz enter password from 3 letters to guess (All Capital): "));

	return 0;
}