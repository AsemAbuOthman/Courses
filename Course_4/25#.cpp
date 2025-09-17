#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadAge() 
{
	int age;

	cout << "Plz Enter your age : ";
	cin >> age;

	return age;
}

bool ValidateNumberInRange(int number, int from, int to) 
{
	return (number >= from && number <= to);
	
}

int ReadUntilAgeBetween(int from, int to) 
{
	int age = 0;

	do 
	{
		age = ReadAge();

	} while (!ValidateNumberInRange(age, from, to));

	return age;
}

void PrintAge(int age) 
{
	if(ValidateNumberInRange(age, 18, 45))
		cout << "Your age is " << age << " you'r Approved" << endl;
	else
		cout << "Your age is " << age << " you'r Rejected" << endl;
}

int main()
{
	int age, from, to;
	
	PrintAge(ReadUntilAgeBetween(18, 45));

	return 0;
}