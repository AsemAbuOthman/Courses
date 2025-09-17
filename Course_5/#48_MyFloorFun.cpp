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

int MyFloor(float num)
{ 
	if (num >= 0)
		return (int)num;
	else if (num == (int)num)
		return num;
	else
		return (int)num - 1;
}

int main()
{
	float num = ReadNum("Plz enter number to find round value : ");

	cout << "My floor Result : ";
	cout << MyFloor(num) << endl;

	cout << "C++ floor Result : ";
	cout << floor(num) << endl;

	cout << endl;

	return 0;
}