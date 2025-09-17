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

string JoinString(string arrText[], short length, string delim)
{
	string result = "";

	for (short i = 0; i < length; i++) 
	{
		result += arrText[i] + delim;
	}

	return result.substr(0, result.length() - delim.length());
}


int main() 
{
	//string text = "Asem Abu Othman";
	vector <string> vText = {"Asem", "Abu", "Othman"};
	string arrText[3] = {"Asem", "Abu", "Othman"};

	cout << "Vector after joining : " << endl;
	cout << JoinString(vText, " ") << endl;

	cout << endl << endl;

	cout << "Array after joining : " << endl;
	cout << JoinString(arrText, 3, " ") << endl;
	
	return 0;
}