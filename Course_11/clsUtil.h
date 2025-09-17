#pragma once

#include <iostream>
#include <string>
#include "clsDate.h"

using namespace std;

class clsUtil
{
public:

	enum enCharType { Digit = 0, Small_Letter = 1, Capital_Letter = 2, Special_Char = 3, MixChars = 4 };

	static void Srand() 
	{
		srand((unsigned)time(NULL));
	}

	static int GenerateRandomNum(int from, int to)
	{

		int randNum = rand() % (to - from + 1) + from;
		return randNum;
	}

	static char GetRandomChar(enCharType CharType)
	{

		if (CharType == MixChars) 
		{
			CharType = (enCharType)GenerateRandomNum(0, 2);
		}

		switch (CharType)
		{
		case enCharType::Small_Letter:
			return GenerateRandomNum(97, 122);
			break;
		case enCharType::Capital_Letter:
			return GenerateRandomNum(65, 90);
			break;
		case enCharType::Special_Char:
			return GenerateRandomNum(33, 47);
			break;
		case enCharType::Digit:
			return GenerateRandomNum(48, 57);
			break;

		default:
			 return GenerateRandomNum(65, 122);
		}

	}

	static string GenerateWord(enCharType CharType, short length)
	{
		string word = "";

		for (int i = 1; i <= length; i++)
		{
			word += GetRandomChar(CharType);

		}

		return word;
	}

	static string GenerateKey(enCharType CharType)
	{
		string key = "";

		key += GenerateWord(CharType, 4) + "-";
		key += GenerateWord(CharType, 4) + "-";
		key += GenerateWord(CharType, 4) + "-";
		key += GenerateWord(CharType, 4);

		return key;
	}

	static void GenrateKeys(short numOfKeys, enCharType CharType)
	{
		int count = 0;

		cout << "Genrated Key(s)" << endl;
		cout << "****************************" << endl;

		for (int i = 1; i <= numOfKeys; i++)
		{
			cout << "Key [" << i << "]: " << GenerateKey(CharType) << endl;
		}
	}

	static void FillArrayWithRandomNums(int arr[], int length, int from, int to)
	{
		for (int i = 0; i < length; i++)
		{
			arr[i] = GenerateRandomNum(from, to);
		}
	}

	static void FillArrayWithRandomWords(string arr[], int length, enCharType CharType, short lengthOfLine)
	{
		for (int i = 0; i < length; i++)
		{
			arr[i] = GenerateWord(CharType, lengthOfLine);
		}
	}

	static void FillArrayWithRandomKeys(string arr[], int length, enCharType CharType)
	{
		for (int i = 0; i < length; i++)
		{
			arr[i] = GenerateKey(CharType);
		}
	}

	static void Swap(int& A, int& B)
	{
		int temp = A;
		A = B;
		B = temp;
	}

	static void Swap(double& A, double& B)
	{
		double temp = A;
		A = B;
		B = temp;
	}

	static void Swap(string& A, string& B)
	{
		string temp = A;
		A = B;
		B = temp;
	}

	static void ShuffleArray(int arr[], int length)
	{

		for (int i = 0; i < length; i++)
		{
			Swap(arr[GenerateRandomNum(1, length) - 1], arr[GenerateRandomNum(1, length) - 1]);
		}
	}

	static void ShuffleArray(string arr[], int length)
	{

		for (int i = 0; i < length; i++)
		{
			Swap(arr[GenerateRandomNum(1, length) - 1], arr[GenerateRandomNum(1, length) - 1]);
		}
	}

	static string EncryptText(string text, short encryptionKey)
	{
		string encryptText = "";

		for (int i = 0; i < text.length(); i++)
		{
			encryptText += char(text[i] + encryptionKey);
		}

		return encryptText;
	}

	static string DecryptText(string encryptText, short encryptionKey)
	{
		string decryptedText = "";

		for (int i = 0; i < encryptText.length(); i++)
		{
			decryptedText += char(encryptText[i] - encryptionKey);
		}

		return decryptedText;
	}

};

