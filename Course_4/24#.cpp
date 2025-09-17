#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadAge() 
{
	int age;

	cout << "Enter your age : ";
	cin >> age;

	return age;
}

bool ValidateNumberInRange(int number, int from, int to) 
{
	return (number >= from && number <= to);
	
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
	
	PrintAge(ReadAge());

	return 0;
}