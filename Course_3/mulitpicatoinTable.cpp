#include <iostream>
#include <string>

using namespace std;

int main()
{
	for (int i = 1; i <= 12; i++) 
	{
		cout << "Multiplication table of " << i << endl;
		cout << "**************************************" << endl;

		for (int j = 1; j <= 12; j++) 
		{
			cout << i << " * " << j << " = " << i * j << endl;
		}

		cout << "\n----------------------------------------" << endl;
		cout << "----------------------------------------\n" << endl;
	}

	return 0;
}