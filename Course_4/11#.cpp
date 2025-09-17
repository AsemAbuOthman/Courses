#include <iostream>
#include <string>

using namespace std;

enum enPassFail { Fail = 0, Pass = 1};

void ReadMarks(int & mark1, int & mark2, int &mark3)
{
	cout << "Enter first mark : ";
	cin >> mark1;

	cout << "Enter second mark : ";
	cin >> mark2;

	cout << "Enter thrid mark : ";
	cin >> mark3;

	cout << endl;
}

int SumOf3Marks(int mark1, int mark2, int mark3)
{
	return mark1 + mark2 + mark3;
}

float CalculateAvg(int mark1, int mark2, int mark3)
{

	return (float)SumOf3Marks(mark1, mark2, mark3) / 3;
}

enPassFail PassFail(float avg)
{

	if (avg >= 50)
		return enPassFail::Pass;
	else
		return enPassFail::Fail;
}

void PrintAvgOf3Marks(float avg)
{

	if(PassFail(avg) == enPassFail::Pass)
		cout << "you'r average is " << avg << " and you'r Passed" << endl;
	else
		cout << "you'r average is " << avg << " and you'r Failed" << endl;

}

int main()
{

	int mark1, mark2, mark3;
	ReadMarks(mark1, mark2, mark3);
	PrintAvgOf3Marks(CalculateAvg(mark1, mark2, mark3));


	return 0;
}