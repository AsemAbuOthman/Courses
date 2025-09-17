#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{	
	int num = 10;

	cout << "value of num is " << num << endl;
	cout << "address of num is " << &num << endl;

	int* p = &num;

	cout << "pointer value is " << p << endl;

	return 0;
}
