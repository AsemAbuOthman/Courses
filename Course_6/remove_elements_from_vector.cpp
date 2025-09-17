#include <iostream>
#include <string>// for getline
#include <vector>

using namespace std;

int main()
{
	vector <int> vNumbers;

	vNumbers.push_back(1);
	vNumbers.push_back(2);
	vNumbers.push_back(3);
	vNumbers.push_back(4);
	vNumbers.push_back(5);

	//vNumbers.pop_back();
	//vNumbers.pop_back();
	//vNumbers.pop_back();
	//vNumbers.pop_back();
	//vNumbers.pop_back();
	//vNumbers.pop_back(); // Very important (this will show error message because vector stack is empty)

	//vNumbers.clear();

	//if (!vNumbers.empty())
	//	vNumbers.pop_back();

	//if (vNumbers.size() > 0)
	//	vNumbers.pop_back();


	cout << "Vector vNumbers = ";

	for (int &numbers : vNumbers) 
	{
		cout << numbers << " ";
	}

	cout << endl;

	return 0;
}

