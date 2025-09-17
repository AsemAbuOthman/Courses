#include <iostream>
#include <string>

using namespace std;

string ReadString(string message) 
{
	string text;

	cout << message << endl;
	getline(cin, text);

	return text;
}

char ReadChar() 
{
	char letter;

	cout << endl;

	cout << "Plz enter a Character : ";
	cin >> letter;


	return letter;
}

short CountLetter(string text, char letter, bool matchCase = true) 
{
	short count = 0;

	for (short i = 0; i < text.length(); i++) 
	{
		if (matchCase)
		{
			if (text[i] == letter)
			{
				count++;
			}
		}
		else
		{
			if (tolower(text[i]) == tolower(letter))
			{
				count++;
			}
		}
	}

	return count;
}

char InvertLetterCase(char letter) 
{

	return isupper(letter) ? tolower(letter) : toupper(letter);
}

int main()
{
	string text = ReadString("Plz enter your string : \n");
	char letter = ReadChar();


	cout << endl;


	cout << "Letter " << letter << " Count = " << CountLetter(text, letter) << endl;
	cout << "Letter " << letter << " or " << InvertLetterCase(letter)<< " Count = " << CountLetter(text, letter, false) << endl;


	system("pause > 0");

	return 0;
}