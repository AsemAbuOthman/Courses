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

int MyCeil(float num)
{ 
	if (num == (int)num)
		return num;
	else if (num < 0)
		return num;
	else
		return num + 1;
}

int main()
{
	float num = ReadNum("Plz enter number to find round value : ");

	cout << "My floor Result : ";
	cout << MyCeil(num) << endl;

	cout << "C++ floor Result : ";
	cout << ceil(num) << endl;

	cout << endl;

	return 0;
}