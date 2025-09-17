#include <iostream>
#include <string>

using namespace std;

enum enWhatToCount { SmallLetters = 0, CapitalLetters = 1, All = 3}; 

string ReadString(string message) 
{
	string text;

	cout << message << endl;
	getline(cin, text);

	return text;
}

short CountLetters(string text, enWhatToCount WhatToCount = enWhatToCount::All)
{
	short count = 0;

	if (WhatToCount == enWhatToCount::All) 
	{
		return text.length();
	}

	for (short i = 0; i < text.length(); i++)
	{
		if (WhatToCount == enWhatToCount::CapitalLetters && isupper(text[i]))
		{
			count++;
		}
		if(WhatToCount == enWhatToCount::SmallLetters && islower(text[i]))
		{
			count++;
		}
	}

	return count;
}


int main()
{
	string text = ReadString("Plz enter your string : \n");

	cout << "\nString Length = " << CountLetters(text) << endl;
	cout << "Capital Letters Count = " << CountLetters(text, enWhatToCount::CapitalLetters) << endl;
	cout << "Small Letters Count = " << CountLetters(text, enWhatToCount::SmallLetters) << endl;


	system("pause > 0");

	return 0;
}