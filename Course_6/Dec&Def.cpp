#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

// function decleration 
void add(int, int);

int main()
{
	add(10, 20);

	return 0;
}

// procedurs deffination
void add(int num1, int num2) 
{
	cout << num1 + num2 << endl;
}