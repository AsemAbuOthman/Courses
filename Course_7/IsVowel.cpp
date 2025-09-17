#include <iostream>
#include <string>

using namespace std;

char ReadChar() 
{
	char letter;

	cout << endl;

	cout << "Plz enter a Character : ";
	cin >> letter;


	return letter;
}

bool IsLetterVowel(char letter) 
{
	letter = tolower(letter);

	return letter == 'a' ||
		letter == 'e' ||
		letter == 'u' ||
		letter == 'i' ||
		letter == 'o' ? true : false;
}

int main()
{
	char letter = ReadChar();

	if (IsLetterVowel(letter)) 
	{
		cout << "Yes : Letter " << letter << " is a vowel" << endl;
	}
	else
	{
		cout << "No : Letter " << letter << " is NOT a vowel" << endl;
	}


	system("pause > 0");

	return 0;
}