#include <iostream>
#include <string>

using namespace std;

int ReadNum() 
{
	int num;

	cout << "Plz Enter your number : ";
	cin >> num;

	return num;
}

float CalculateNum(int num) 
{

	return (float)num / 2;
}

void PrintHalfNum(int num) 
{
	string result = "Hlaf of " + to_string(num) + " is " + to_string(CalculateNum(num));
	cout << result << endl;
}


int main()
{
	PrintHalfNum(ReadNum());


	return 0;
}