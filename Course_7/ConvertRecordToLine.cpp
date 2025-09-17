#include <iostream>
#include <string>
#include <vector>
#include <cctype>
#include "clsString.h"

using namespace std;

struct stClientData
{
	int PinCode = 0;
	string Name = "";
	string AccountNumber = "";
	string Phone = "";
	float AccountBallance = 0;

};

stClientData ReadNewClient() 
{
	stClientData ClientData;

	
	cout << "Enter Account Number ? ";
	cin >> ClientData.AccountNumber;

	cout << "Enter PinCode ? ";
	cin >> ClientData.PinCode;

	cout << "Enter Name ? ";
	cin.ignore('\n');
	getline(cin, ClientData.Name);

	cout << "Enter Phone ? ";
	cin >> ClientData.Phone;

	cout << "Enter AccountBallance ? ";
	cin >> ClientData.AccountBallance;

	cout << endl << endl;

	return ClientData;
}

string ConvertRecordToLine(stClientData ClientData, string spreator = "#//#")
{
	string stClientData = "";

	stClientData += ClientData.AccountNumber + spreator;
	stClientData += to_string(ClientData.PinCode) + spreator;
	stClientData += ClientData.Name + spreator;
	stClientData += ClientData.Phone + spreator;
	stClientData += to_string(ClientData.AccountBallance);

	return stClientData;
}

int main() 
{
	stClientData ClientData;

	cout << "Plz Enter Client Data : \n\n";

	ClientData = ReadNewClient();

	cout << "Client Record for Saving is : " << endl;

	cout << ConvertRecordToLine(ClientData);

	system("pause > 0");

	return 0;
}