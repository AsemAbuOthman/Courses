#include <iostream>
#include <string>

using namespace std;

enum enStatus {Rejected = 0, Hired = 1};

struct strPersonInfo 
{
	int Age;
	bool HasDriverLicense;
};

strPersonInfo ReadPersonInfo()
{
	strPersonInfo PersonInfo;

	cout << "Enter your age : ";
	cin >> PersonInfo.Age;

	cout << "\nEnter (1/0) if you has a driver license : ";
	cin >> PersonInfo.HasDriverLicense;

	cout << endl;

	return PersonInfo;
}

enStatus Status(strPersonInfo PersonInfo) 
{
	if (PersonInfo.Age >= 21 && PersonInfo.HasDriverLicense == 1)
		return enStatus::Hired;
	else
		return enStatus::Rejected;


}

void PrintPersonInfo(strPersonInfo PersonInfo)
{
	if (Status(PersonInfo))
		cout << "Hired" << endl;
	else
		cout << "Rejected" << endl;
}

int main()
{
	PrintPersonInfo(ReadPersonInfo());

	return 0;
}