#include <iostream>
#include <string>
#include <cmath>

using namespace std;

enum enMonthsOfYear {Jan = 1, Feb = 2, Mar= 3, Apr = 4, May = 5,
					 Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10,
					 Nov = 11, Dec = 12};

int ReadPositiveNumber(string message) 
{
	int day = 0;

	do 
	{
		cout << message;
		cin >> day;

	} while (!(day <= 12 && day >= 1));
	
	cout << endl;

	return day;
}

enMonthsOfYear ReadMonthsOfYear()
{
	return (enMonthsOfYear)ReadPositiveNumber("Plz enter month : ");
}

string GetMonthsOfYear(enMonthsOfYear MonthsOfYear)
{

	switch (MonthsOfYear)
	{
	case enMonthsOfYear::Jan:
		return "Jan";
	case enMonthsOfYear::Feb:
		return "Feb";
	case enMonthsOfYear::Mar:
		return "Mar";
	case enMonthsOfYear::Apr:
		return "Apr";
	case enMonthsOfYear::May:
		return "May";
	case enMonthsOfYear::Jun:
		return "Jun";
	case enMonthsOfYear::Aug:
		return "Aug";
	case enMonthsOfYear::Sep:
		return "Sep";
	case enMonthsOfYear::Oct:
		return "Oct";
	case enMonthsOfYear::Nov:
		return "Nov";
	case enMonthsOfYear::Dec:
		return "Dec";

	defualt:
		return "Not a Valid Months";
	}
}

int main()
{
	cout << "Month is " << GetMonthsOfYear(ReadMonthsOfYear()) << endl;

	return 0;
}