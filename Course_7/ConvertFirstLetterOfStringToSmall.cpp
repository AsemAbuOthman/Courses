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

string GetFirstUpperLetterOfWord(string text) 
{
	bool isFirstLetter = true;

	cout << endl << "First letter of this string : " << endl;

	for (short i = 0; i < text.length(); i++) 
	{

		if (text[i] != ' ' && isFirstLetter)
		{
			text[i] = tolower(text[i]);
		}

		isFirstLetter = (text[i] == ' ' ? true : false);
	}
	
	return text;
}

int main()
{
	cout << GetFirstUpperLetterOfWord(ReadString("Plz enter your string : ")) << endl;

	return 0;
}