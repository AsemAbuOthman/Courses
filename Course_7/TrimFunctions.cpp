#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

string ReadString(string message) 
{
	string text;

	cout << message;
	getline(cin, text);

	return text;
}

string TrimLeft(string text) 
{

	for(short i = 0; i < text.length() - 1; i++)
	{	
		if (text[i] != ' ')
		{
			return text.substr(i, text.length() - 1);
		}
	}

	return text;
}

string TrimRight(string text)
{
	for (short i = text.length() - 1; i >= 0; i--)
	{
		if (text[i] != ' ')
		{
			return text.substr(0, i + 1);
		}
	}

	return text;
}

string Trim(string text) 
{

	return TrimLeft(TrimRight(text));
}

int main()
{
	string text = ReadString("Plz enter a string : ");


	cout << "\nString		" << " = " << text << endl << endl;

	cout << "Trim Left	" << " = " << TrimLeft(text) << endl;
	cout << "Trim Right	" << " = " << TrimRight(text) << " Ture" << endl;
	cout << "Trim		" << " = " << Trim(text) << " Ture" << endl;

	system("pause > 0");

	return 0;
}