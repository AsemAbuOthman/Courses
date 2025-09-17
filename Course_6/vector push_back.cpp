#include <iostream>
#include <vector>

using namespace std;

int main()
{
	vector <int> vNumbers;

	cout << "Vector numbers = ";

	vNumbers.push_back(10);
	vNumbers.push_back(20);
	vNumbers.push_back(30);
	vNumbers.push_back(40);
	vNumbers.push_back(50);
	vNumbers.push_back(60);
	vNumbers.push_back(70);
	vNumbers.push_back(80);
	vNumbers.push_back(90);

	for (int &number : vNumbers) // Plz call by refrence because without & for make a copy each time
	{
		cout << number << " ";
	}

	cout << endl;

	return 0;
}

