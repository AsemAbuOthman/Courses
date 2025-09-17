#include <iostream>
#include <string>

using namespace std;

int main()
{
	short month;

	cout << "Plz enter Month number : ";
	cin >> month;

	cout << "\nIts ";

	switch (month)
	{
	case 1:
		cout << "Jun" << endl;
		break;
	case 2:
		cout << "Feb" << endl;
		break;

	case 3:
		cout << "Mar" << endl;
		break;

	case 4:
		cout << "Apr" << endl;
		break;

	case 5:
		cout << "May" << endl;
		break;

	case 6:
		cout << "June" << endl;
		break;

	case 7:
		cout << "July" << endl;
		break;

	case 8:
		cout << "Aug" << endl;
		break;

	case 9:
		cout << "Sep" << endl;
		break;

	case 10:
		cout << "Oct" << endl;
		break;

	case 11:
		cout << "Nov" << endl;

	case 12:
		cout << "Dec" << endl;
		break;

	default:
		cout << "Wrong Month :(" << endl;
	}

	return 0;
}