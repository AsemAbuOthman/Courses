#include <iostream>
#include <string>
#include <vector>
#include <cctype>
#include <fstream>
#include <iomanip>
using namespace std;

struct stClientData
{
	string PinCode = "";
	string Name = "";
	string AccountNumber = "";
	string Phone = "";
	float AccountBallance = 0;

};

string Tab(short numberOfTabs = 0) 
{
	string tab = "";

	for (short i = 0; i < numberOfTabs; i++) 
	{
		if (numberOfTabs == 0)
		{
			cout << "\t";
		}

		tab += "\t";
	}

	return tab;
}

void ReadDataFromFileToVector(string fileName, vector <string>& vFileContent)
{

	fstream MyFile;

	MyFile.open(fileName, ios::in);

	if (MyFile.is_open())
	{
		string line;

		while (getline(MyFile, line))
		{

			vFileContent.push_back(line);

		}

		MyFile.close();
	}

}

vector<string> ReadDataStoreInVector(string lineData, string spreator)
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

stClientData GetClientData(vector<string> vData)
{
	stClientData ClientData;

	ClientData.AccountNumber = vData[0];
	ClientData.PinCode = vData[1];
	ClientData.Name = vData[2];
	ClientData.Phone = vData[3];
	ClientData.AccountBallance = stof(vData[4]);

	return ClientData;
}

void PrintClientList() 
{
	vector<string> vFileContent;
	stClientData ClientData;

	ReadDataFromFileToVector("MyFile.txt", vFileContent);

	cout << "                                      Client List (" << vFileContent.size() << ")" << " Client(s).\n\n";
	cout << " --------------------------------------------------------------------------------------------------\n\n";
	cout << " | "  << left << setw(20) << "Account Number" << " | " << left << setw(18) << "Pin Code"  <<  " | " << left << setw(18) << "Client Name" << " | " << left << setw(13) << "Phone" << " | " << left << setw(10) << "Account Ballance\n\n";
	cout << "\n --------------------------------------------------------------------------------------------------\n\n";

	vector<string> vData;

	for (short i = 0; i < vFileContent.size(); i++) 
	{
		vData = ReadDataStoreInVector(vFileContent[i], "#//#");
		
		ClientData = GetClientData(vData);

			cout << " | " << left << setw(20) << ClientData.AccountNumber
				 << " | " << left << setw(18) << ClientData.PinCode
				 << " | " << left << setw(18) << ClientData.Name
				 << " | " << left << setw(13) << ClientData.Phone
				 << " | " << left << setw(10) << ClientData.AccountBallance<< "\n\n";


	}

	cout << "\n\n --------------------------------------------------------------------------------------------------\n";

}


int main()
{
	PrintClientList();

	system("pause > 0");

	return 0;
}