#include <iostream>
#include <string>
#include <vector>
#include <cctype>
#include "clsString.h"

using namespace std;

struct stClientData
{
	string AccountNumber = "";
	int PinCode = 0;
	string Name = "";
	string Phone = "";
	float AccountBallance = 0;

};

string ReadString(string message = "Plz enter a string : ")
{
	string text = "";

	cout << message;

	getline(cin, text);

	cout << endl;

	return text;
}

vector<string> ReadDataStoreInVector(string lineData,string spreator) 
{
	vector<string> vData;

	for (short i = 0; i < lineData.length(); i++) 
	{
		if (lineData[i] == spreator[0])
		{

			vData.push_back(lineData.substr(0, lineData.find(spreator[0])));

			lineData.erase(0, lineData.find(spreator[0]) + spreator.length());

			i = 0;
		}

	}

	if (lineData[0] != ' ')
	{
		vData.push_back(lineData);
	}

	return vData;
}

stClientData ConvertDataLineToRecord(stClientData ClientData, vector<string> vData)
{
	ClientData.AccountNumber = vData.at(0);
	ClientData.PinCode = stoi(vData.at(1));
	ClientData.Name = vData.at(2);
	ClientData.Phone = vData.at(3);
	ClientData.AccountBallance = stof(vData.at(4));

	return ClientData;
}

void PrintExtractedRecord(stClientData ClientData)
{
	cout << "Account Number  : " << ClientData.AccountNumber << endl;
	cout << "Pin Code        : " << ClientData.PinCode << endl;
	cout << "Name            : " << ClientData.Name << endl;
	cout << "Phone           : " << ClientData.Phone << endl;
	cout << "Account Ballance: " << ClientData.AccountBallance << endl;

	cout << endl;
}

int main() 
{
	string lineData = ReadString();
	vector<string> vData = ReadDataStoreInVector(lineData, "#//#");	
	stClientData ClientData;

	cout << "Line Record is : " << endl;

	cout << lineData << endl << endl;

	ClientData = ConvertDataLineToRecord(ClientData, vData);

	cout << "The following is the extracted client record : " << endl << endl;
	PrintExtractedRecord(ClientData);


	system("pause > 0");

	return 0;
}