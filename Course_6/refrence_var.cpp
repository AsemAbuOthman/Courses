#include <iostream>
#include <string>// for getline
#include <vector>

using namespace std;

int main()
{
	int a = 10;
	int &x = a; // refrence variable

	cout << "a address : " << &a << endl;
	cout << "x address : " << &x << endl;

	x = 20;

	cout << "a value : " << a << endl;
	cout << "x value : " << x << endl;



	return 0;
}

