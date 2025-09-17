#include <iostream>
#include <string>

using namespace std;


int main() 
{
	double grade[3];
	double avgGrade;

	cout << "Plz enter first grade : ";
	cin >> grade[0];

	cout << "Plz enter second grade : ";
	cin >> grade[1];

	cout << "Plz enter third grade : ";
	cin >> grade[2];
	
	avgGrade = (grade[0] + grade[1] + grade[2]) / (sizeof(grade) / sizeof(grade[0]));

	cout << "\nYour average is " << avgGrade << endl;

	return 0;
}