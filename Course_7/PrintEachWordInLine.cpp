#include <iostream>
#include <string>
#include <cctype>
#include <cstdlib>
using namespace std;

string ReadString(string message) 
{
	string text;

	cout << message;
	getline(cin, text);

	return text;
}
void PrintEachWordOnALine(string text) 
{
	string word;

	for (short i = 0; i < text.length(); i++) 
	{	
		if (text[i] != ' ' && i != text.length() - 1)
		{
			word.push_back(text[i]);
		}
		else
		{

			cout << word << endl;

			word = "";
		}
	}
}

int main()
{
	string text = ReadString("Plz enter a string : ");

	PrintEachWordOnALine(text);

	system("pause > 0");

	return 0;
}