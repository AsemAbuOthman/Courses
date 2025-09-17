#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(float &r)
{
	cout << "Enter circle riduos  : ";
	cin >> r;


	cout << endl;
}

float CalculateCircleAera(float r)
{
	const float pi = 22.0 / 7;

	return pi * (r * r);
}

void PrintResult(float r)
{
	cout << "Cyrcle area = " << r << endl;
}



int main()
{
	float r;
	ReadNum(r);
	PrintResult(CalculateCircleAera(r));

	return 0;
}