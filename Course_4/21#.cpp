#include <iostream>
#include <string>
#include <cmath>

using namespace std;

float ReadCircumferenceSide()
{
	float l;

	cout << "Enter along the circumference : ";
	cin >> l;


	cout << endl;

	return l;
}

float CalculateCircleAreaCircumference(float l)
{
	const float pi = 22.0 / 7;

	return pow(l, 2) / (4 * pi);
}

void PrintResult(float l)
{
	cout << "Cyrcle area = " << l << endl;
}



int main()
{
	
	PrintResult(CalculateCircleAreaCircumference(ReadCircumferenceSide()));
	
	return 0;
}