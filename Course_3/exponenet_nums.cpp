#include <iostream>
#include <string>

using namespace std;

int main()
{
	int num, exp, result = 1;

	cout << "Enter number to find exponent : ";
	cin >> num;

	cout << "Enter the Exponent number : ";
	cin >> exp;
	cout << endl;

	if (exp != 0)
	{
		result = num;

		for (int i = 1; i < exp; i++)
		{
			result *= num;

		}

	}

	cout << num << "^" << exp << " = " << result << endl;

	return 0;
}