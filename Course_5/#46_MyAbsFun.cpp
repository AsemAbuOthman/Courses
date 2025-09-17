#include <iostream>
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

float MyAbs(float num) 
{
	if (num < 0)
		return num * -1;

	return num;
}

int main()
{
	float num = ReadNum("Plz enter number to find absoluate value : ");

	cout << "My abs Result : ";
	cout << MyAbs(num) << endl;

	cout << "C++ abs Result : ";
	cout << abs(num) << endl;

	cout << endl;

	return 0;
}