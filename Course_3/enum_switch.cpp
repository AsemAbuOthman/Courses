#include <iostream>
#include <string>

using namespace std;

enum enWeekDay {Sun = 1, Mon = 2, Tue = 3, Wed = 4, Thu = 5, Fri = 6, Sat = 7};

void ShowWeekdayMenu() 
{
	cout << "************************" << endl;
	cout << "\tWeek Days" << endl;
	cout << "************************" << endl;
	cout << "1: Sunday" << endl;
	cout << "2: Monday" << endl;
	cout << "3: Tuesday" << endl;
	cout << "4: Wednsday" << endl;
	cout << "5: Thursday" << endl;
	cout << "6: Friday" << endl;
	cout << "7: Saturday" << endl;
	cout << "************************" << endl;

}

enWeekDay ReadWeekDay() 
{
	enWeekDay WeekDay;

	cout << "Plz enter weekday number : ";
	int weekDay;
	cin >> weekDay;

	return (enWeekDay)weekDay;
}

string GetWeekDay(enWeekDay WeekDay) 
{
	switch (WeekDay) 
	{
	case enWeekDay::Sun:
		return "Sunday";
		break;
	case enWeekDay::Tue:
		return "Tuesday";
		break;

	case enWeekDay::Wed:
		return "Wednsday";
		break;

	case enWeekDay::Thu:
		return "Thusday";
		break;

	case enWeekDay::Fri:
		return "Friday";
		break;

	case enWeekDay::Sat:
		return "Saturday";
		break;

	default:
		return "Wrong Day";
	}
}

int main()
{
	ShowWeekdayMenu();
	cout << "Today is " << GetWeekDay(ReadWeekDay());

	return 0;
}