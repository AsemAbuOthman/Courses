#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadPositiveNumber() 
{
	int hours;

	do 
	{
		cout << "Plz enter number of hours : ";
		cin >> hours;

	} while (hours < 0);

	return hours;
}

float HoursToDays(float hours) 
{
	float days = hours / 24;

	return days;
}

float HoursToWeeks(float hours) 
{
	float weeks = HoursToDays(hours) / 7;

	return weeks;
}

float DaysToWeeks(float hours)
{
	float weeks = HoursToDays(hours) / 7;

	return weeks;
}

int main()
{
	int numOfHours = ReadPositiveNumber();
	int numOfDays = HoursToDays(numOfHours);
	int numOfWeeks = DaysToWeeks(numOfHours);


	cout << numOfWeeks << " Weeks" << endl;
	cout << numOfDays << " Days" << endl;
	
	return 0;
}