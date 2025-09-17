#pragma once

#include<iostream>

using namespace std;

namespace MyValidLib 
{
	int ReadNum(string message)
	{
		int number = 0;

		cout << message;
		cin >> number;

		while (cin.fail())
		{
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(), '\n');

			cout << "Invalid Number, Enter a valid one: ";
			cin >> number;

		}

		return number;
	}

}