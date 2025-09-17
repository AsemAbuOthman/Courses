#include <iostream>
#include <string>// for getline
#include <vector>

using namespace std;

int main()
{
	vector <int> vNumbers;

	for (int i = 1; i <= 5; i++) 
	{
		vNumbers.push_back(i);
	}

	cout << "First element in vector is : " << vNumbers.front() << endl;
	cout << "Last element in vector is : " << vNumbers.back() << endl;
	cout << "Number of elements in vector : " << vNumbers.size() << endl;
	cout << "vector capacity : " << vNumbers.capacity() << endl;
	cout << "Is vector empty ? " << vNumbers.empty() << endl;


	cout << "Vector vNumbesr = ";

	for (int &number : vNumbers) 
	{
		cout << number << " ";
	}

	cout << endl;

	vNumbers.clear();

	while (!vNumbers.empty() || vNumbers.size() > 0)
	{
		vNumbers.pop_back();
	}

	return 0;
}

