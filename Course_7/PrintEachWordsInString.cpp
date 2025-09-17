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
	string delim = " ";

	cout << "\nYour string words are : " << endl << endl;
	short pos = 0;
	string word;

	while ((pos = text.find(delim)) != word.npos)
	{
		word = text.substr(0, pos);
		
		if (word != "")
		{
			cout << word << endl;
		}
	
		text.erase(0, pos + delim.length());
	}

	if (text != "")
	{
		cout << text << endl;
	}

}

int main()
{
	string text = ReadString("Plz enter a string : ");

	PrintEachWordOnALine(text);

	system("pause > 0");

	return 0;
}