#include <iostream>
#include <string>

using namespace std;

int main()
{
	short day;

	cout << "Plz enter the day : ";
	cin >> day;
	

	if (day >= 1 && day <= 7)
	{
		if (day == 1)
			cout << "Sunday" << endl;
		else if (day == 2)
			cout << "Monday" << endl;
		else if (day == 3)
			cout << "Thursday" << endl;
		else if (day == 4)
			cout << "Wednsday" << endl;
		else if (day == 5)
			cout << "Tuesday" << endl;
		else if (day == 6)
			cout << "Firday" << endl;
		else
			cout << "Saturday" << endl;
	}
	else
		cout << "Wrong Day" << endl;





	return 0;
}