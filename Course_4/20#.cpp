#include <iostream>
#include <string>
#include <cmath>

using namespace std;

float ReadSquareSide()
{
	float a;

	cout << "Enter Inscribed In Square  : ";
	cin >> a;


	cout << endl;

	return a;
}

float CalculateCircleAreaInscribedInSquare(float a)
{
	const float pi = 22.0 / 7;

	return (pi * pow(a, 2)) / 4;
}

void PrintResult(float a)
{
	cout << "Cyrcle area = " << a << endl;
}



int main()
{
	
	PrintResult(CalculateCircleAreaInscribedInSquare(ReadSquareSide()));
	
	return 0;
}