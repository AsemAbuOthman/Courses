#include <iostream>
#include<cmath>
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

float GetFractionPart(float num) 
{
	return num - (int)num;
}

int MyRound(float num) 
{
	int intPart;
	intPart = (int)num;

	float fractionPart = GetFractionPart(num);

	if (abs(fractionPart) >= 0.5)
	{
		if (num > 0)
			return ++intPart;
		else
			return --intPart;
	}
	else
	{
		return intPart;
	}
}

int main()
{
	float num = ReadNum("Plz enter number to find round value : ");

	cout << "My round Result : ";
	cout << MyRound(num) << endl;

	cout << "C++ round Result : ";
	cout << round(num) << endl;

	cout << endl;

	return 0;
}