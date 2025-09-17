#include <iostream>
#include <string>
#include <vector>
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

string StringToLowerCase(string text) 
{
	for (short i = 0; i < text.length(); i++) 
	{
		text[i] = tolower(text[i]);
	}

	return text;
}

vector <string> SplitStringInVector(string text) 
{
	vector <string> textWords;
	short pos = 0;

	while (pos != string::npos) 
	{
		if ((pos = text.find(" ")) != string::npos)
		{
			textWords.push_back(text.substr(0, pos));
			text.erase(0, pos + 1);
		}
	}

	if (text[0] != ' ')
	{
		textWords.push_back(text);
	}

	return textWords;
}

string JoinString(vector <string> textWords, string delim)
{
	string newString = "";

	for (short i = 0; i < textWords.size(); i++) 
	{
		newString += textWords[i] + delim;
	}
	
	return newString.substr(0, newString.length() - delim.length());
}

string ReplaceWordInString(string orginalString, string stringToReplace, string stringReplaceTo, bool matchedCase = true)
{
	vector <string> textWords = SplitStringInVector(orginalString);

	short pos = 0;

	if (matchedCase) 
	{
		if (orginalString.find(stringToReplace) != string::npos) 
		{
			orginalString.erase(0, orginalString.length());

			for (string &text : textWords) 
			{
				if (text == stringToReplace) 
				{
					text = stringReplaceTo;
				}

				orginalString += text + " ";
			}
		}
	}
	else 
	{
		orginalString.erase(0, orginalString.length());

		stringToReplace = StringToLowerCase(stringToReplace);

		for (string &text : textWords) 
		{
			if (StringToLowerCase(text) == stringToReplace)
			{
				text = stringReplaceTo;
			}

			orginalString += text + " ";
		}
	}

	return orginalString.substr(0, orginalString.length() - 1);
}

int main() 
{
	string text = "Welcome to Jordan , Jordan is a nice country";

	cout << "Original String : " << endl;
	cout << text << endl;

	cout << endl << endl;

	cout << "Replace with match case : " << endl;
	cout << ReplaceWordInString(text, "Jordan", "USA") << endl;

	cout << endl << endl;

	cout << "Replace without match case : " << endl;
	cout << ReplaceWordInString(text, "JORDAN", "USA", false) << endl;

	return 0;
}