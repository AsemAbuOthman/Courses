#include <iostream>
#include <string>

using namespace std;

string ReadString(string message) 
{
	string text;

	cout << message;
	getline(cin, text);

	return text;
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

void PrintVowelsInString(string text)
{
	short count = 0;

	cout << "Vowels in String are : ";

	for (short i = 0; i < text.length(); i++) 
	{
		if(IsLetterVowel(text[i]))
		{	
			cout << text[i] << "\t";
		}
	}

	cout << endl;
}

int main()
{
	string text = ReadString("Plz enter a string : ");

	PrintVowelsInString(text);

	system("pause > 0");

	return 0;
}