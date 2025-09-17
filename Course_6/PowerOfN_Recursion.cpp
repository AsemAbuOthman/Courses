#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int PowerOfN(int base, int exp)
{
	if (exp == 0)
		return 1;
	else
		return (base * PowerOfN(base, exp - 1));

}

int main()
{
	cout << PowerOfN(10, 3) << endl;

	return 0;
}

