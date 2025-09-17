#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

enum enCharType { Digit = 0, Small_Letter = 1, Capital_Letter = 2, Special_Char = 3 };

int ReadPoaitiveNum(string message) 
{
	int num = 0;

	do 
	{
		cout << message;
		cin >> num;
		cout << endl;

	} while (num <= 0);


	return num;
}


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

string GenerateWord(enCharType CharType, short length)
{
	string word = "";

	for (int i = 1; i <= length; i++)
	{
		word += GetRandomChar(CharType);

	}

	return word;
}

string GenerateKey()
{
	string key = "";

	key += GenerateWord(enCharType::Capital_Letter, 4) + "-";
	key += GenerateWord(enCharType::Capital_Letter, 4) + "-";
	key += GenerateWord(enCharType::Capital_Letter, 4) + "-";
	key += GenerateWord(enCharType::Capital_Letter, 4);

	return key;
}

void ReadArray(string arr[100], int length)
{

	for (int i = 0; i < length; i++)
	{
		arr[i] = GenerateKey();
	}
}

void PrintStringArray(string arr[100], int length)
{
	for (int i = 0; i < length; i++) 
	{
		cout << "Array[" << i << "]: ";
		cout << arr[i] << endl;
	}

	cout << endl;
}

int main()
{
	srand((unsigned)time(NULL));

	string arr[100];
	int	length = ReadPoaitiveNum("Plz enter number of elements : ");

	ReadArray(arr, length);
	cout << "Array Elements : \n\n";
	PrintStringArray(arr, length);

	cout << endl;

	return 0;
}