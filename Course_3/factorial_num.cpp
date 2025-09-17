#include <iostream>
#include <string>

using namespace std;

int main()
{
	int num, fact = 1;

	cout << "Enter number to find factorial : ";
	cin >> num;
	cout << endl;

	for (int i = num; i >= 1; i--)
	{
		fact *= i;
	}

	cout << fact << endl;

	return 0;
}