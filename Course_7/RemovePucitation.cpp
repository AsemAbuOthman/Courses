#include <iostream>
#include <string>
#include <vector>
#include <cctype>
#include "clsString.h"

using namespace std;




string RemovePunctuations(string text) 
{	
	cout << endl;

	string S1 = "";

	for (short i = 0; i < text.length(); i++) 
	{

		if (!ispunct(text[i]))
		{
			S1 += text[i];
		}

	}

	cout << endl;


	return S1;
}



int main() 
{
	cout << RemovePunctuations("Hi, I'm Asem Abu Othman . {}[];'~`/*-+.,?!:");

	return 0;
}