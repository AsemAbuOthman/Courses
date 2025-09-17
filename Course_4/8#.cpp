#include <iostream>
#include <string>

using namespace std;

enum enPassFail {Fail = 0, Pass = 1};

int ReadMark() 
{
	int mark;

	cout << "Plz enter your mark : ";
	cin >> mark;

	return mark;
}

enPassFail CheckMark(int mark) 
{
	if (mark >= 50)
		return enPassFail::Pass;
	else
		return enPassFail::Fail;
}

void PrintMark(int mark) 
{
	enPassFail PassFail;

	string message = "You'r mark is " + to_string(mark) + " you'r " + to_string(CheckMark(mark));

	cout << message << endl;
}

int main()
{
	PrintMark(ReadMark());


	return 0;
}