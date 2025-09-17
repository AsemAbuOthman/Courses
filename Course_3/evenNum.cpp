#include <iostream>
#include <string>

using namespace std;

int main()
{
	int num = 1, range, sum = 0;

	cout << "Enter number to print sum of odd numbers between 1 and it : ";
	cin >> range;

	while (num <= range) 
	{
		if (range % 2 == 0) 
		{
			sum += range;
			range -= 2;
		}
		else
		{
			range -= 1;
		}

	}

	cout << "Sum of even numbers is " << sum << endl;
	
	return 0;
}