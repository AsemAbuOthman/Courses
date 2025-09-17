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

void FirstLetterOfEachWord() 
{
	string text = ReadString("Plz enter your string : ");

	bool isFirstLetter = true;	

	cout << endl << "First letters of this string : " << endl;
	cout << text[0] << endl;

	for (short i = 0; i < text.length(); i++)
	{
		if (text[i] == ' ' && isFirstLetter)
		{
			cout << text[i] << endl;
		}

		isFirstLetter = text[i] == ' ' ? true : false;
	}
}

int main()
{
	FirstLetterOfEachWord();

	return 0;
}