#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

void PrintNumbersInReverse(int to, int from)
{
	if(to >= from)
	{
		cout << to << endl;
		PrintNumbersInReverse(to - 1, from);
	}
}

int main()
{
	PrintNumbersInReverse(10, 0);

	return 0;
}

