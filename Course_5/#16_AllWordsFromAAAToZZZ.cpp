#include <iostream>
#include <string>
#include <cmath>

using namespace std;


int ReadPositiveNum(string message)
{
	int num;

	do
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num <= 0);

	cout << endl;

	return num;
}


void PrintAllWordsFromAAAToZZZ()
{
	string word = "";

	for (int i = 65; i <= 90; i++)
	{
		for (int j = 65; j <= 90; j++)
		{	
			for (int k = 65; k <= 90; k++) 
			{
				word += char(i);
				word += char(j);
				word += char(k);

				cout << word << endl;

				word = "";
			}
		}

	}

}


int main()
{
	PrintAllWordsFromAAAToZZZ();

	return 0;
}