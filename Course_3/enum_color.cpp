#include <iostream>
#include <string>

using namespace std;

enum enScreenColor{Red = 1, Green = 2, Blue = 3, yellow = 4};

int main()
{
	short colorNum;
	enScreenColor Color;

	cout << "********************" << endl;
	cout << "(1) Red \n";
	cout << "(2) Green \n";
	cout << "(3) Blue \n";
	cout << "(4) Yellow \n";
	cout << "********************" << endl;

	cin >> colorNum;

	Color = (enScreenColor)colorNum;

	if (Color < 1 || Color > 4)
		cout << "Invalid Color" << endl;
	else
	{
		if (Color == enScreenColor::Red)
			system("color 4F");
		else if (Color == enScreenColor::Green)
			system("color 2F");
		else if (Color == enScreenColor::Blue)
			system("color 1F");
		else
			system("color 6F");
	}




	return 0;
}