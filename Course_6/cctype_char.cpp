#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main()
{	
	//	Very easy (EASY PIZZY LEMON SQUIZZY)

	char x, y;

	x = toupper('a');
	y = tolower('Z');

	cout << "toupper('a') : " << x << endl;
	cout << "tolower('Z') : " << y << endl;

	cout << "isupper('A') : " << isupper('A') << endl;
	cout << "islower('A') : " << islower('A') << endl;

	cout << "ispunct('?') : " << ispunct('?') << endl;

	return 0;
}
