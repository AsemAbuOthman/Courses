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

short CountNumebrsOfCapitalLettrs(string text) 
{
	short count = 0;

	for (short i = 0; i < text.length(); i++) 
	{
		if (isupper(text[i]))
		{
			count++;
		}
	}

	return count;
}

short CountNumebrsOfSmallLettrs(string text)
{
	short count = 0;

	for (short i = 0; i < text.length(); i++)
	{
		if (islower(text[i]))
		{
			count++;
		}
	}

	return count;
}

int main()
{
	string text = ReadString("Plz enter your string : \n");

	cout << "\nString Length = " << text.length() << endl;
	cout << "Capital Letters Count = " << CountNumebrsOfCapitalLettrs(text) << endl;
	cout << "Small Letters Count = " << CountNumebrsOfSmallLettrs(text) << endl;


	system("pause > 0");

	return 0;
}