#include <iostream>
#include <string>
#include <cctype>
#include <cstdlib>
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

void PrintVectorElements(vector<string> &vResult) 
{
	for (string &result : vResult) 
	{
		cout << result << endl;
	}
}

int main()
{
	string text = ReadString("Plz enter a string : ");
	vector<string> vResult = SplitString(text, " ");

	cout << "Tokens = " << vResult.size() << endl;
	PrintVectorElements(vResult);

	system("pause > 0");

	return 0;
}