#include <iostream>
#include <string>
#include <vector>
#include <cctype>
#include <fstream>
using namespace std;

struct stClientData
{
	string PinCode = "";
	string Name = "";
	string AccountNumber = "";
	string Phone = "";
	float AccountBallance = 0;

};

stClientData ReadNewClient()
{
	stClientData ClientData;

	cout << endl << "Plz Enter Client Data : \n\n";

	cout << "Enter Account Number ? ";
	getline(cin >> ws, ClientData.AccountNumber);

	cout << endl;

	cout << "Enter PinCode ? ";
	getline(cin, ClientData.PinCode);
	

	cout << endl;

	cout << "Enter Name ? ";
	getline(cin, ClientData.Name);

	cout << endl;

	cout << "Enter Phone ? ";
	getline(cin, ClientData.Phone);

	cout << endl;

	cout << "Enter AccountBallance ? ";
	cin >> ClientData.AccountBallance;

	cout << endl << endl;

	return ClientData;
}

string ConvertRecordToLine(stClientData ClientData, string spreator = "#//#")
{
	string stClientData = "";

	stClientData += ClientData.AccountNumber + spreator;
	stClientData += ClientData.PinCode + spreator;
	stClientData += ClientData.Name + spreator;
	stClientData += ClientData.Phone + spreator;
	stClientData += to_string(ClientData.AccountBallance);

	return stClientData;
}

bool DoYouWantToAddMore(char doYouWantToAdd)
{
	if (doYouWantToAdd == 'n')
	{
		return false;
	}

	return true;
}

void AddClientToFile(string clientRecord) 
{
	fstream MyFile; 

	MyFile.open("MyFile.txt", ios::out | ios::app);// Write modes

	if (MyFile.is_open())
	{
		MyFile << clientRecord << endl;

		MyFile.close();
	}
}

void AddNewClient(stClientData ClientData)
{
	
	char doYouWantToAddMore;

	ClientData = ReadNewClient();
	AddClientToFile(ConvertRecordToLine(ClientData));

	cout << "Client Added Sccessfully, do you want to add more ? ";
	cin >> doYouWantToAddMore;

	if (DoYouWantToAddMore(doYouWantToAddMore))
	{
		AddNewClient(ClientData);
	}
}

int main()
{
	stClientData ClientData;

	AddNewClient(ClientData);

	system("pause > 0");

	return 0;
}