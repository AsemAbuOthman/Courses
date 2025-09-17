#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>
#include <vector>

using namespace std;

int main()
{	
	vector<int> vNumbers = {10, 20, 30, 40, 50};

	vector<int>::iterator iter;

	for (iter = vNumbers.begin(); iter != vNumbers.end(); iter++) 
	{
		cout << *iter << " ";
	}

	cout << endl;

	return 0;
}
