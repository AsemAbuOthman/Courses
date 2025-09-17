#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int MySum(int num1, int num2 , int num3 = 0, int num4 = 0) 
{
	return (num1 + num2 + num3 + num4);
}

int main()
{
	cout << MySum(10, 20) << endl;
	cout << MySum(10, 20, 30) << endl;
	cout << MySum(10, 20, 30, 40) << endl;

	return 0;
}

