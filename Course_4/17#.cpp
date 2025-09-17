#include <iostream>
#include <string>
#include <cmath>

using namespace std;

void ReadNum(float &b, float &h)
{
	cout << "Enter first base  : ";
	cin >> b;

	cout << "Enter second height : ";
	cin >> h;

	cout << endl;
}

float CalculateTriangelAera(float b, float h) 
{
	return b/2 * h;
}

void PrintResult(float b, float h)
{
	cout << "Triangle area = " << CalculateTriangelAera(b, h) << endl;
}



int main()
{
	float b, h;
	ReadNum(b, h);
	PrintResult(b, h);

	return 0;
}