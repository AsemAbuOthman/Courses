#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{	
	int num = 0;

	cout << num << endl;
	cout << &num << endl;

	cout << endl;

	int* p = &num;

	cout << p << endl;
	cout << *p << endl;// Derefrenceing

	cout << endl;

	*p = 1;

	cout << p << endl;
	cout << *p << endl;

	cout << endl;

	num = 2;

	cout << p << endl;
	cout << *p << endl;

	return 0;
}
