#include <iostream>
#include <string>

using namespace std;

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

void PrintAvgOf3Marks(int mark1, int mark2, int mark3)
{
	cout << "Your avg is " << CalculateAvg(mark1, mark2, mark3) << endl;

}

int main()
{

	int mark1, mark2, mark3;
	ReadMarks(mark1, mark2, mark3);
	PrintAvgOf3Marks(mark1, mark2, mark3);


	return 0;
}