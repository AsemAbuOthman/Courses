#include <iostream>
#include <string>

using namespace std;

int main()
{
	int num, sum = 0;

	cout << "Enter number to find sum of odd numbers from your number to 1 : ";
	cin >> num;
	cout << endl;

	for (int i = 1; i <= num; i += 2)
	{
		sum += i;
	}

	cout << sum << endl;

	return 0;
}