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

short CountLetters(string text)
{
	short count = 0;

	for (short i = 0; i < text.length(); i++) 
	{
		if(IsLetterVowel(text[i]))
		{
			count++;
			continue;
		}
	}

	return count;
}

int main()
{
	string text = ReadString("Plz enter a string : ");

	cout << "Number of vowels is : " << CountLetters(text) << endl;

	system("pause > 0");

	return 0;
}