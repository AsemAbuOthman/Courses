#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

float ReadNum(string message) 
{
	float num = 0;

	cout << message;
	cin >> num;

	cout << endl;

	return num;
}

float MySqrt(float num)
{ 
	return pow(num, 0.5);
}

int main()
{
	float num = ReadNum("Plz enter number to find square root value : ");

	cout << "My sqrt Result : ";
	cout << MySqrt(num) << endl;

	cout << "C++ sqrt Result : ";
	cout << sqrt(num) << endl;

	cout << endl;

	return 0;
}