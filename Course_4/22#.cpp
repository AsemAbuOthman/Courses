#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadTeiangleIncreibed(float &l, float &b)
{

	cout << "Enter along the legs : ";
	cin >> l;

	cout << "Enter along the base : ";
	cin >> b;


	cout << endl;

	
}

float CalculateCircleArea(float l, float b)
{
	const float pi = 22.0 / 7;

	return pi * (pow(b, 2) / 4) * ((2 * l - b) / (2 * l + b));
}

void PrintResult(float l, float b)
{
	cout << "Cyrcle area = " << CalculateCircleArea(l, b) << endl;
}



int main()
{
	float l, b;
	ReadTeiangleIncreibed(l, b);
	PrintResult(l, b);
	
	return 0;
}