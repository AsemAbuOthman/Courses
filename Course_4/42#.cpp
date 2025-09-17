#include <iostream>
#include <string>
#include <cmath>

using namespace std;

struct strTaskDuration 
{
	int Days, Hours, Minutes, Seconds;
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

	ReadPositiveNumber("Plz enter the days : ", TaskDuration.Days);
	ReadPositiveNumber("Plz enter the hours : ", TaskDuration.Hours);
	ReadPositiveNumber("Plz enter the minutes : ", TaskDuration.Minutes);
	ReadPositiveNumber("Plz enter the seconds : ", TaskDuration.Seconds);

	return TaskDuration;
}

int TaskDurationInSeconds(strTaskDuration TaskDuration)
{
	int totalSeconds = 0;

	totalSeconds += TaskDuration.Days * 24 * 60 * 60;
	totalSeconds += TaskDuration.Hours * 60 * 60;
	totalSeconds += TaskDuration.Minutes * 60;
	totalSeconds += TaskDuration.Seconds ;

	return totalSeconds;
}

int main()
{
	cout << TaskDurationInSeconds(ReadTaskDuration()) << " Seconds" << endl;
	
	return 0;
}