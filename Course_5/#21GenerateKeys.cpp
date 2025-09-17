#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;



int ReadNum(string message) 
{
	int num = 0;

	do 
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num < 0);

	cout << endl;

	return num;
}



void GenrateKeys(short numOfKeys) 
{
	int count = 0;

	cout << "Genrated Key(s)" << endl;
	cout << "****************************" << endl;

	for (int i = 1; i <= numOfKeys; i++) 
	{
		cout << "Key [" << i << "]: " << GenerateKey() << endl;
	}
}

int main()
{
	//Seeds the random number genrator in C++, called only once
	srand((unsigned)time(NULL));

	GenrateKeys(ReadNum("Plz enter number of keys : "));

	return 0;
}