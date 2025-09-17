#include <iostream>
#include <string>

using namespace std;

struct strInfo 
{
	string FirstName;
	string LastName;
};

strInfo ReadInfo() 
{
	strInfo Info;

	cout << "Plz enter your first name : ";
	cin >> Info.FirstName;

	cout << "Plz enter your Last name : ";
	cin >> Info.LastName;

	cout << endl;

	return Info;
}

string GetFullName(strInfo Info, bool reversed) 
{
	string fullName = "";

	if(reversed)
		fullName = Info.LastName + " " + Info.FirstName;
	else
		fullName = Info.FirstName + " " + Info.LastName;

	return fullName;
}

void PrintFullName(string fullName)
{
	cout << "Full name is " << fullName << endl;
}

int main()
{

	PrintFullName(GetFullName(ReadInfo(),false));

	return 0;
}