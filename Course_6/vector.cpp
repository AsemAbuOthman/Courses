#include <iostream>
#include <vector>

using namespace std;

int main()
{
	vector <int> vNumbers = {10, 20, 30, 40, 50};

	cout << "Vector numbers = ";

	for (int &number : vNumbers) // Plz call by refrence because without & for make a copy each time
	{
		cout << number << " ";
	}

	cout << endl;

	return 0;
}

