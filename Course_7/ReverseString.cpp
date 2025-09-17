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

vector<string> SplitString(string text, string delim)
{
	vector<string> vResult;

	string word;
	short pos = 0;

	while ((pos = text.find(delim)) != string::npos)
	{
		word = text.substr(0, pos);

		if (word != "")
		{
			vResult.push_back(word);
		}

		text.erase(0, pos + delim.length());
	}

	if (text != "")
	{
		vResult.push_back(text);
	}

	return vResult;
}

string ReverseWordsInString(string text) 
{
	vector<string> vText  = SplitString(text, " ");
	string reverseText = "";
	
	vector<string>::iterator iter = vText.end();

	while (iter != vText.begin()) 
	{
	
		--iter;

		reverseText += *iter + " ";

	}
	
	reverseText = reverseText.substr(0, reverseText.length() - 1);

	return reverseText;
}


int main() 
{
	string text = ReadString("Plz enter your string : ");

	cout << endl << endl;

	cout << "String after reversing words : " << endl;
	cout << ReverseWordsInString(text) << endl;


	return 0;
}