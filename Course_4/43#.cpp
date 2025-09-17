#include <iostream>
#include <string>
#include <cmath>

using namespace std;

struct strTaskDuration 
{
	int Weeks, Days, Hours, Minutes, Seconds;
};

int ReadPositiveNumber(string message, int &num) 
{

	do 
	{
		cout << message;
		cin >> num;

	} while (num < 0);
	
	cout << endl;

	return num;
}

strTaskDuration ReadTaskDuration() 
{
	strTaskDuration TaskDuration;

	ReadPositiveNumber("Plz enter the seconds : ", TaskDuration.Seconds);

	return TaskDuration;
}

void TaskDurationInDaysHoursMinutesSeconds(strTaskDuration TaskDuration)
{
	const int secondsPerWeek = 7 * 24 * 60 * 60;
	const int secondsPerDay = 24 * 60 * 60;
	const int secondsPerhour = 60 * 60;
	const int secondsPerMinutes = 60;

	int reminder = 0;
	TaskDuration.Weeks = floor(TaskDuration.Seconds / secondsPerWeek);
	reminder = TaskDuration.Seconds % secondsPerWeek;
	TaskDuration.Days = floor(TaskDuration.Seconds / secondsPerDay);
	reminder = TaskDuration.Seconds % secondsPerDay;
	TaskDuration.Hours = floor(reminder / secondsPerhour);
	reminder = TaskDuration.Seconds % secondsPerhour;
	TaskDuration.Minutes = floor(reminder / secondsPerMinutes);
	reminder = TaskDuration.Seconds % secondsPerMinutes;
	TaskDuration.Seconds = reminder;

	cout << TaskDuration.Weeks << ":"
		<< TaskDuration.Days << ":" << TaskDuration.Hours << ":" 
		<< TaskDuration.Minutes << ":" << TaskDuration.Seconds << endl;

}

int main()
{
	TaskDurationInDaysHoursMinutesSeconds(ReadTaskDuration());
	
	return 0;
}