#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadTeiangleData(float &a, float &b, float& c)
{

	cout << "Enter along the a : ";
	cin >> a;

	cout << "Enter along the b : ";
	cin >> b;

	cout << "Enter along the c : ";
	cin >> c;

	cout << endl;

	
}

float CalculateCircleAreaByTriangle(float a, float b, float c)
{
	const float pi = 22.0 / 7;
	float p = (a + b + c) / 2;
	float T = (a * b * c) / (4 * sqrt(p * (p - a) * (p - b) * (p - c)));
	return pi * pow(T, 2);
}

void PrintResult(float a, float b, float c)
{
	cout << "Cyrcle area = " << CalculateCircleAreaByTriangle(a, b, c) << endl;
}



int main()
{
	float a, b, c;
	ReadTeiangleData(a, b, c);
	PrintResult(a, b, c);
	
	return 0;
}