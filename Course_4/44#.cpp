#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enWeekDays {Sunday = 1, Monday = 2, Tuesday= 3, Wednsday = 4, Thursday = 5, Firday = 6, Saturday = 7};

int ReadPositiveNumber(string message) 
{
	int day = 0;

	do 
	{
		cout << message;
		cin >> day;

	} while (!(day <= 7 && day >= 1));
	
	cout << endl;

	return day;
}

enWeekDays ReadWeekDays() 
{
	return (enWeekDays)ReadPositiveNumber("Plz enter day : ");
}

string GetDayOfWeek(enWeekDays WeekDay) 
{

	switch (WeekDay)
	{
	case enWeekDays::Sunday:
		return "Sunday";
	case enWeekDays::Monday:
		return "Monday";
	case enWeekDays::Tuesday:
		return "Tuesday";
	case enWeekDays::Wednsday:
		return "Wednsday";
	case enWeekDays::Thursday:
		return "Thursday";
	case enWeekDays::Firday:
		return "Firday";
	case enWeekDays::Saturday:
		return "Saturday";
	defualt:
		return "Not a Valid Day";
	}
}

int main()
{
	cout << "Today is " << GetDayOfWeek(ReadWeekDays()) << endl;

	return 0;
}