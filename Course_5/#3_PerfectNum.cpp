#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enPerfectNotPerfect {NotPerfect = 0, Perfect = 1};

int ReadPositiveNum(string message) 
{
	int num;

	do 
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num <= 0);

	cout << endl;

	return num;
}

int SumOfPerfectNums(int num) 
{
	int sum = 0;

	for (int i = 1; i < num; i++)
	{
		if (num % i == 0)
			sum += i;

	}

	return sum;
}

enPerfectNotPerfect CheckPerfectNum(int num, int sum) 
{

	if (sum == num)
		return enPerfectNotPerfect::Perfect;
	else
		return enPerfectNotPerfect::NotPerfect;

}

void PrintPerfectOrNotPerfectNum(int num) 
{
	if(CheckPerfectNum(num, SumOfPerfectNums(num)) == enPerfectNotPerfect::Perfect)
		cout << num << " is perfect." << endl;
	else
		cout << num << " is not perfect." << endl;
}

int main()
{
	PrintPerfectOrNotPerfectNum(ReadPositiveNum("Plz enter number th check if perfect number or not : "));

	return 0;
}