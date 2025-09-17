#include <iostream>
#include <string>

using namespace std;

char InvertChar(char letter) 
{
	return isupper(letter) ? tolower(letter) : toupper(letter);
}

int main()
{
	
	cout << InvertChar('A') << endl;


	return 0;
}