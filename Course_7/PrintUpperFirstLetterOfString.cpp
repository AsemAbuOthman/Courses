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

		if ((text[i] != ' ' && isFirstLetter) && isupper(text[i]))
		{
			cout << text[i] << endl;
		}
	
		isFirstLetter = (text[i + 1] != ' ' ? true : false);
	}
	
}

int main()
{
	PrintFirstUpperLetterOfWord();

	return 0;
}