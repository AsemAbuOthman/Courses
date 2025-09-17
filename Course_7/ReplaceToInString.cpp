#include <iostream>
#include <string>
#include <vector>

using namespace std;

string ReadString(string message) 
{
	string text;

	cout << message;
	getline(cin, text);

	return text;
}

string ReplaceWordInStringUsingBuiltInFunctions(string orginalString, string stringToReplace, string stringReplaceTo) 
{
	short pos = orginalString.find(stringToReplace);

	while (pos != string::npos) 
	{
		orginalString = orginalString.replace(pos, stringToReplace.length(), stringReplaceTo);

		pos = orginalString.find(stringToReplace);
	}

	return orginalString;
}

int main() 
{
	string text = "Welcome to Jordan , Jordan is a nice country";

	cout << "Original String : " << endl;
	cout << text << endl;

	cout << endl << endl;
	
	cout << "String After Replace : " << endl;
	cout << ReplaceWordInStringUsingBuiltInFunctions(text, "Jordan", "USA") << endl;

	return 0;
}