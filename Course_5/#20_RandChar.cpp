#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

enum enCharType {Digit = 0, Small_Letter = 1, Capital_Letter = 2, Special_Char = 3 };

int RandomNum(int from, int to) 
{
	int randNum = 0;

	randNum = rand() % (to - from + 1) + from;

	return randNum;
}

char GetRandomChar(enCharType CharType)
{
	switch (CharType) 
	{
	case enCharType::Small_Letter:
		return RandomNum(97, 122);
		break;
	case enCharType::Capital_Letter:
		return RandomNum(65, 90);
		break;
	case enCharType::Special_Char:
		return RandomNum(33, 47);
		break;
	case enCharType::Digit:
		return RandomNum(48, 57);
		break;

	}

}

int main()
{
	//Seeds the random number genrator in C++, called only once
	srand((unsigned)time(NULL));

	cout << GetRandomChar(enCharType::Small_Letter) << endl;
	cout << GetRandomChar(enCharType::Capital_Letter) << endl;
	cout << GetRandomChar(enCharType::Special_Char) << endl;
	cout << GetRandomChar(enCharType::Digit) << endl;

	return 0;
}