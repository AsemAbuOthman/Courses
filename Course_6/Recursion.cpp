#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

void PrintNumbers(int from, int to)
{
	if(from <= to)
	{
		cout << from << endl;
		PrintNumbers(from + 1, to);
	}
}

int main()
{
	PrintNumbers(1, 3994); // Watch out from (STACK OVERFLOW)

	return 0;
}

