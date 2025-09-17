#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>
#include <vector>

using namespace std;

int main()
{	
	vector <int> vNumbers = {10,20,30,40,50,60};

	cout << "Using .at(i) " << endl;
	cout << "Element at Index 0: " << vNumbers.at(0) << endl;
	cout << "Element at Index 3: " << vNumbers.at(3) << endl;
	cout << "Element at Index 5: " << vNumbers.at(5) << endl;

	cout << endl;

	cout << "Using [i] " << endl;
	cout << "Element at Index 0: " << vNumbers[0] << endl;
	cout << "Element at Index 3: " << vNumbers[3] << endl;
	cout << "Element at Index 5: " << vNumbers[5] << endl;

	return 0;
}
