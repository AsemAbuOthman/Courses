#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int GenerateRandomNum(int from, int to) 
{

	int randNum = rand() % (to - from + 1) + from;
	return randNum;
}

int main()
{
	//Seeds the random number genrator in C++, called only once
	srand((unsigned)time(NULL));
	int randNum = 0;

	while (randNum != 50) 
	{
		randNum = GenerateRandomNum(1, 50);

		cout << randNum << endl;
	}


	return 0;
}