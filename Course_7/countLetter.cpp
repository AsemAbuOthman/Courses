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

short CountLetter(string text, char letter) 
{
	short count = 0;

	for (short i = 0; i < text.length(); i++) 
	{
		if (text[i] == letter)
		{
			count++;
		}
	}

	return count;
}

int main()
{
	string text = ReadString("Plz enter your string : \n");
	char letter = ReadChar();

	cout << endl;


	cout << "Letter " << letter << " Count = " << CountLetter(text, letter) << endl;

	system("pause > 0");

	return 0;
}