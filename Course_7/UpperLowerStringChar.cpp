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

string ConvertStringToUpperCase(string text) 
{

	for (short i = 0; i < text.length(); i++) 
	{
		if (text[i] != ' ' && text[i] <= 'z' && text[i] >= 'a')
		{
			text[i] = text[i] - ' ';
		}
	}

	return text;
}

string ConvertStringToLowerCase(string text)
{

	for (short i = 0; i < text.length(); i++)
	{
		if (text[i] != ' ' && text[i] <= 'Z' && text[i] >= 'A')
		{
			text[i] = text[i] +' ';
		}
	}

	return text;
}

int main()
{
	string text = ReadString("Plz enter your string : \n");

	cout << "\n******************************************" << endl;
	cout << "String after Upper : " << endl << endl;
	cout << ConvertStringToUpperCase(text) << endl;
	cout << "******************************************" << endl;


	cout << endl;

	cout << "******************************************" << endl;
	cout << "String after Lower : " << endl << endl;
	cout << ConvertStringToLowerCase(text) << endl;
	cout << "******************************************" << endl;


	return 0;
}