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

string ReadString(string message) 
{
	string text = "";

	cout << message;

	getline(cin, text);

	cout << endl << endl;

	return text;
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

	ClientData.AccountNumber = vData.at(0);
	ClientData.PinCode = vData.at(1);
	ClientData.Name = vData.at(2);
	ClientData.Phone = vData.at(3);
	ClientData.AccountBallance = stof(vData.at(4));

	return ClientData;
}

//void PrintClientList() 
//{
//	vector<string> vFileContent;
//	stClientData ClientData;
//
//	ReadDataFromFileToVector("MyFile.txt", vFileContent);
//
//	cout << "                                      Client List (" << vFileContent.size() << ")" << " Client(s).\n\n";
//	cout << " --------------------------------------------------------------------------------------------------\n\n";
//	cout << " | "  << left << setw(20) << "Account Number" << " | " << left << setw(18) << "Pin Code"  <<  " | " << left << setw(18) << "Client Name" << " | " << left << setw(13) << "Phone" << " | " << left << setw(10) << "Account Ballance\n\n";
//	cout << "\n --------------------------------------------------------------------------------------------------\n\n";
//
//	vector<string> vData;
//
//	for (short i = 0; i < vFileContent.size(); i++) 
//	{
//		vData = ReadDataStoreInVector(vFileContent[i], "#//#");
//		
//		ClientData = GetClientData(vData);
//
//			cout << " | " << left << setw(20) << ClientData.AccountNumber
//				 << " | " << left << setw(18) << ClientData.PinCode
//				 << " | " << left << setw(18) << ClientData.Name
//				 << " | " << left << setw(13) << ClientData.Phone
//				 << " | " << left << setw(10) << ClientData.AccountBallance<< "\n\n";
//
//
//	}
//
//	cout << "\n\n --------------------------------------------------------------------------------------------------\n";
//
//}

string FindClientData(string accountNumber, stClientData &ClientData)
{
	vector<string> vFileContent;
	
	ReadDataFromFileToVector("MyFile.txt", vFileContent);

	for (short i = 0; i < vFileContent.size(); i++)
	{	
		ClientData = GetClientData(ReadDataStoreInVector(vFileContent[i], "#//#"));

		if (ClientData.AccountNumber == accountNumber)
		{

			return vFileContent[i];
		}
	}
	
	return "";
}

void SaveVectorToFile(string fileName, vector<string>& vFileContent)
{
	fstream MyFile;

	MyFile.open(fileName, ios::out);

	if (MyFile.is_open())
	{

		for (string& line : vFileContent)
		{
			if (line != " ")
			{
				MyFile << line << endl;
			}
		}

		MyFile.close();
	}

}

string JoinString(vector <string> vText, string delim)
{
	string result = "";

	for (string& text : vText)
	{
		result += text + delim;
	}

	return result.substr(0, result.length() - delim.length());
}


void UpdateClinetData(stClientData ClientData, string delim, string fileName, vector<string> vFileContent, string lineData) 
{
	char yesOrNo = 'Y';

	vector<string> vData;

	cout << "\nAre you sure you want to update this client ? [y/n] ? ";
	cin >> yesOrNo;

	yesOrNo = toupper(yesOrNo);

	if (yesOrNo == 'Y')
	{
		cout << endl << endl;

		vData.push_back(ClientData.AccountNumber);

		cout << "Enter Pin Code ? ";
		cin >> ClientData.PinCode;

		vData.push_back(ClientData.PinCode);

		cout << "Enter Name ? ";
		cin >> ClientData.Name;

		vData.push_back(ClientData.Name);

		cout << "Enter Phone ? ";
		cin >> ClientData.Phone;

		vData.push_back(ClientData.Phone);

		cout << "Enter Account Ballance ? ";
		cin >> ClientData.AccountBallance;

		vData.push_back(to_string(ClientData.AccountBallance));

		cout << "Client Updated Successfully." << endl;
	}

	string newData = JoinString(vData, delim);


	for (string &fileContent : vFileContent) 
	{
		if(fileContent == lineData)
		{
			fileContent = newData;
			break;
		}
	}

	SaveVectorToFile(fileName, vFileContent);
}

void PrintClientData(string accountNumber, stClientData ClientData) 
{
	if (ClientData.AccountNumber == accountNumber)
	{
		cout << "The following are the client details:\n\n";

		cout << "AccountNumber   : " << ClientData.AccountNumber << endl;
		cout << "PinCode         : " << ClientData.PinCode << endl;
		cout << "Name            : " << ClientData.Name << endl;
		cout << "Phone           : " << ClientData.Phone << endl;
		cout << "AccountBallance : " << ClientData.AccountBallance << endl;
	}
	else
	{
		cout << "Client with account number (" << accountNumber << ") Not found!" << endl;
	}

}

int main()
{
	stClientData ClientData;

	vector<string> vFileContent;
	string fileName = "MyFile.txt";

	string accountNumber = ReadString("Plz enter Account Number : ");
	ReadDataFromFileToVector(fileName, vFileContent);

	string lineData = FindClientData(accountNumber, ClientData);
		
	PrintClientData(accountNumber, ClientData);

	UpdateClinetData(ClientData, "#//#", fileName, vFileContent, lineData);

	system("pause > 0");

	return 0;
}