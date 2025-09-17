#include <iostream>
#include <string>

using namespace std;

int main()
{	
	string text = "Hi this my first C++ program today :), I love programming";

	//	return number of charctars
	cout << text.length() << endl;

	// return char at some index
	cout << text.at(3) << endl;

	// add some text to tail of string
	cout << text.append(" @ProgrammingAdvices") << endl;

	// add some text in spec. position
	cout << text.insert(7, " Asem") << endl;

	// return part of string
	cout << text.substr(16, 8) << endl;

	// push char to tail of string
	text.push_back('X');

	cout << text << endl;

	// pop char to tail of string
	text.pop_back();

	// retrun index of first char if text found
	cout << text.find("Asem") << endl;

	if (text.find("Koko") == text.npos)
	{
	
		cout << "Not found" << endl;
	
	}

	return 0;
}
