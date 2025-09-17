#include <iostream>
#include <string>

using namespace std;

int main()
{
	short month;

	cout << "Plz enter the month : ";
	cin >> month;
	

	if (month >= 1 && month <= 12)
	{
		if (month == 1)
			cout << "January" << endl;
		else if (month == 2)
			cout << "Frbruary" << endl;
		else if (month == 3)
			cout << "March" << endl;
		else if (month == 4)
			cout << "April" << endl;
		else if (month == 5)
			cout << "May" << endl;
		else if (month == 6)
			cout << "June" << endl;
		else if (month == 7)
			cout << "July" << endl;
		else if (month == 8)
			cout << "August" << endl;
		else if (month == 9)
			cout << "September" << endl;
		else if (month == 10)
			cout << "October" << endl;
		else if (month == 11)
			cout << "November" << endl;
		else
			cout << "December" << endl;
	}
	else
		cout << "Wrong Month" << endl;





	return 0;
}