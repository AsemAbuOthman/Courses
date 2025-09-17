#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>
#include <vector>

using namespace std;

int main()
{	

	vector <int> vNumbers = {10, 20, 30, 40, 50};

	cout << "Initial Vector : ";
	for (const int &Number : vNumbers) 
	{
		cout << Number << " ";
	}

	cout << endl;

	cout << "Updated Vector : ";
	for (int &Number : vNumbers) 
	{
		Number = 10;
		cout << Number << " ";
	}

	cout << endl;

	vNumbers.at(0) = 0;
	vNumbers[4] = 100;

	for (const int &Number : vNumbers) 
	{
		cout << Number << " ";
	}

	cout << endl;

	return 0;
}
