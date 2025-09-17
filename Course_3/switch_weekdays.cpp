#include <iostream>
#include <string>

using namespace std;

int main()
{
	short day;

	cout << "Plz enter day number : ";
	cin >> day;

	cout << "\nIts ";

	switch (day) 
	{
	case 1:
		cout << "Sun" << endl;
		break;
	case 2:
		cout << "Mon" << endl;
		break;

	case 3:
		cout << "Tue" << endl;
		break;

	case 4:
		cout << "Wed" << endl;
		break;

	case 5:
		cout << "Thu" << endl;
		break;

	case 6:
		cout << "Fri" << endl;
		break;

	case 7:
		cout << "Sat" << endl;
		break;

	default:
		cout << "Wrong Day :(" << endl;
	}

	return 0;
}