#include <iostream>
#include <string>
#include <cmath>

using namespace std;


float ReadNum(string message) 
{
	float num = 0;

	cout << message;
	cin >> num;

	cout << endl;

	return num;
}

float SumNum() 
{
	int num = 0, sum = 0, count = 1;
	
	cout << "Plz enter number to sum it until you enter -99 : " << endl;

	do 
	{
		num = ReadNum("Enter number " + to_string(count) + " : ");

		if (num == -99)
			break;

		sum += num;

		count++;
	
	} while (num != -99);

	return sum;
}

int main()
{
	cout << "Sum = " << SumNum();

	return 0;
}