#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>
#include <cstdio>
#include <iomanip>

using namespace std;

int main()
{
	cout << " ---------|--------------------------------------------|--------- " << endl;
	cout << "|   Code  |                    Name                    |   Mark  |" << endl;
	cout << "|---------|--------------------------------------------|---------|" << endl;


	cout << "|" << setw(9) << "CS50" << "|" << setw(44) << "Calculas" << "|" << setw(9) << "90" << "|" << endl;
	cout << "|" << setw(9) << "CIS120" << "|" << setw(44) << "Manegment Information Systems" << "|" << setw(9) << "80" << "|" << endl;
	cout << "|" << setw(9) << "AI15202" << "|" << setw(44) << "Artifical Inteligence" << "|" << setw(9) << "75" << "|" << endl;
	cout << " " << setw(9) << "---------" << "|" << setw(44) << "--------------------------------------------" << "|" << setw(9) << "---------" << " " << endl;

	return 0;
}

