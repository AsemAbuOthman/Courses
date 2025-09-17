#include <iostream>
#include <string>
#include <vector>

using namespace std;

string JoinString(vector <string> vText, string delim)
{
	string result = "";

	for (string &text : vText) 
	{
		result += text + delim;
	}

	return result.substr(0, result.length() - delim.length());
}

int main() 
{
	//string text = "Asem Abu Othman";
	vector <string> vText = {"Asem", "Abu", "Othman"};

	cout << JoinString(vText, " ") << endl;

	return 0;
}