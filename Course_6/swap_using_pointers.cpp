#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

void Swap(int *p1, int *p2) 
{
	int temp;
	temp = *p1;
	*p1 = *p2;
	*p2 = temp;
}

int main()
{	

	int num1, num2;

	num1 = 10;
	num2 = 20;

	cout << "num1 = " << num1 << endl;
	cout << "num2 = " << num2 << endl;

	cout << endl;

	Swap(&num1, &num2);

	cout << "num1 = " << num1 << endl;
	cout << "num2 = " << num2 << endl;


	cout << endl;

	return 0;
}
