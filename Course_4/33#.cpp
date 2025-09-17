#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int ReadPositiveNum() 
{
	int grade;

	do 
	{
		cout << "Plz enter your grade : ";
		cin >> grade;

		cout << "**************************" << endl;

	} while (grade < 0 && grade > 100);

	cout << endl;

	return grade;
}

char GetGradeLetter(int grade) 
{
	if (grade >= 90)
		return 'A';
	else if (grade >= 80)
		return 'B';
	else if (grade >= 70)
		return 'C';
	else if (grade >= 60)
		return 'D';
	else if (grade >= 50)
		return 'E';
	else
		return 'F';
}


int main()
{	
	cout << GetGradeLetter(ReadPositiveNum()) << endl;

	return 0;
}