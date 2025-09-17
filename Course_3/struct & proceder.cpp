#include <iostream>
#include <string>

using namespace std;

struct strInfo 
{
	string FullName;
	int Age;
	string City;
	string Country;
	int MonthlySalary;
	int YearlySalary;
	char Gender;
	bool IsMarried;

};

void ReadInfo(strInfo &Info) 
{
	cout << "Enter your name : ";
	cin >> Info.FullName;

	cout << "\nEnter your age : ";
	cin >> Info.Age;

	cout << "\nEnter your city : ";
	cin >> Info.City;

	cout << "\nEnter your country : ";
	cin >> Info.Country;

	cout << "\nEnter your monthly salary : ";
	cin >> Info.MonthlySalary;

	Info.YearlySalary = Info.MonthlySalary * 12;

	cout << "\nEnter your gender (M\\F) : ";
	cin >> Info.Gender;

	cout << "\nAre you married (1\\0) ? ";
	cin >> Info.IsMarried;
}

void PrintInfo(strInfo Info) 
{
	cout << "\n\n****************************" << endl;
	cout << "Name : " << Info.FullName << endl;
	cout << "Age : " << Info.Age << endl;
	cout << "City : " << Info.City << endl;
	cout << "Country : " << Info.Country << endl;
	cout << "MonthlySalary : " << Info.MonthlySalary << endl;
	cout << "YearlySalary : " << Info.YearlySalary << endl;
	cout << "Gender : " << Info.Gender << endl;
	cout << "IsMarried : " << Info.IsMarried << endl;
	cout << "****************************\n" << endl;

}

int main() 
{

	strInfo Person1Info;
	ReadInfo(Person1Info);
	PrintInfo(Person1Info);

	strInfo Person2Info;
	ReadInfo(Person2Info);
	PrintInfo(Person2Info);


	return 0;
}