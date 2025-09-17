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

void PrintFirstUpperLetterOfWord() 
{
	string text = ReadString("Plz enter your string : ");
	bool isFirstLetter = true;

	cout << endl << "First letter of this string : " << endl;

	for (short i = 0; i < text.length(); i++) 
	{

		if (text[i] != ' ' && isFirstLetter)
		{
			text[i] = toupper(text[i]);
		}

		isFirstLetter = (text[i] == ' ' ? true : false);
	}
	
	cout << text << endl;

}

int main()
{
	PrintFirstUpperLetterOfWord();

	return 0;
}