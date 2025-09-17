#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(float &d)
{
	cout << "Enter circle diameter  : ";
	cin >> d;


	cout << endl;
}

float CalculateCircleAeraByDiameter(float d)
{
	const float pi = 22.0 / 7;

	return (pi * pow(d, 2)) / 4;
}

void PrintResult(float d)
{
	cout << "Cyrcle area = " << d << endl;
}



int main()
{
	float d;
	ReadNum(d);
	PrintResult(CalculateCircleAeraByDiameter(d));

	return 0;
}