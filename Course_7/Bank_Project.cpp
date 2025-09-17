#include <iostream>
#include <string>
#include <vector>
#include <cctype>
#include <fstream>
#include <iomanip>

using namespace std;

enum enMainMenuScreen { ShowClient = 1, AddClient = 2, DeleteClient = 3, UpdateClient = 4, FindClient = 5, Exit = 6 };

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

	getline(cin >> ws, text);

	cout << endl << endl;

	return text;
}

void GoBackToMainMenu(short &choice)
{

	cout << "Press any key to go back to Main Menu..." << endl;
	system("pause > 0");

	system("cls");
	cout << "=====================================" << endl;
	cout << "\t    Main Menu Screen" << endl;
	cout << "=====================================" << endl;

	cout << "\t[1] Show Client List." << endl;
	cout << "\t[2] Add New Client." << endl;
	cout << "\t[3] Delete Client." << endl;
	cout << "\t[4] Update Client." << endl;
	cout << "\t[5] Find Client." << endl;
	cout << "\t[6] Exit." << endl;

	cout << "=====================================" << endl;
	cout << "Choose what do you want to do ? [1 to 6] ? ";
	cin >> choice;
	cout << endl;

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
	cout << " | " << left << setw(20) << "Account Number" << " | " << left << setw(18) << "Pin Code" << " | " << left << setw(18) << "Client Name" << " | " << left << setw(13) << "Phone" << " | " << left << setw(10) << "Account Ballance\n\n";
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
			<< " | " << left << setw(10) << ClientData.AccountBallance << "\n\n";


	}

	cout << "\n\n --------------------------------------------------------------------------------------------------\n";

}

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

	cout << "Client Added Sccessfully, do you want to add more ? [y/n] ? ";
	cin >> doYouWantToAddMore;

	if (DoYouWantToAddMore(doYouWantToAddMore))
	{
		AddNewClient(ClientData);
	}

}

string FindClientData(string accountNumber, stClientData& ClientData)
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

void SaveVectorToFile(string fileName, vector<string>& vNames)
{
	fstream MyFile;

	MyFile.open(fileName, ios::out);

	if (MyFile.is_open())
	{

		for (string& line : vNames)
		{
			if (line != " ")
			{
				MyFile << line << endl;
			}
		}

		MyFile.close();
	}

}

void DeleteClientFromFile(string accountNumber, stClientData ClientData, string fileName, vector<string>& vFileContent, string lineData)
{
	string doYouWant = ReadString("Are you sure you want to delete this client ? [y/n] ? ");

	doYouWant[0] = toupper(doYouWant[0]);

	if (ClientData.AccountNumber == accountNumber && doYouWant == "Y")
	{

		for (string& fileContent : vFileContent)
		{
			if (lineData == fileContent)
			{
				fileContent = " ";

				cout << "Client Deleted Successfully ." << endl;
			}
		}

		SaveVectorToFile(fileName, vFileContent);
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

		cout << "\nClient Updated Successfully." << endl;
	}

	string newData = JoinString(vData, delim);


	for (string& fileContent : vFileContent)
	{
		if (fileContent == lineData)
		{
			fileContent = newData;
			break;
		}
	}

	SaveVectorToFile(fileName, vFileContent);
}

stClientData GetClientData(string accountNumber)
{
	vector<string> vFileContent;

	ReadDataFromFileToVector("MyFile.txt", vFileContent);

	stClientData ClientData;

	for (short i = 0; i < vFileContent.size(); i++)
	{
		stClientData ClientData = GetClientData(ReadDataStoreInVector(vFileContent[i], "#//#"));

		if (ClientData.AccountNumber == accountNumber)
		{
			return ClientData;
		}

	}

	return ClientData;
}

void PrintClientData(string accountNumber, stClientData ClientData)
{


	if (ClientData.AccountNumber == accountNumber)
	{
		cout << "The following are the client details:\n\n";

		cout << "================================================" << endl;
		cout << "AccountNumber   : " << ClientData.AccountNumber << endl;
		cout << "PinCode         : " << ClientData.PinCode << endl;
		cout << "Name            : " << ClientData.Name << endl;
		cout << "Phone           : " << ClientData.Phone << endl;
		cout << "AccountBallance : " << ClientData.AccountBallance << endl;
		cout << "================================================" << endl;

		cout << endl;
	}
	else
	{
		cout << "Client with account number (" << accountNumber << ") Not found!" << endl;
	}

}

void ExitApp()
{
	exit(0);
}

void MainMenuScreen(short choice)
{
	stClientData ClientData;

	string accountNumber;
	string fileName = "MyFile.txt";
	vector<string> vFileContent;
	string lineData;

	switch (choice)
	{

	case enMainMenuScreen::ShowClient:

		system("cls");
		PrintClientList();

		GoBackToMainMenu(choice);
		MainMenuScreen(choice);
		break;

	case enMainMenuScreen::AddClient:

		cout << "=====================================" << endl;
		cout << "\tAdd New Clinets Screen" << endl;
		cout << "=====================================" << endl;

		cout << "Adding New Clients :" << endl << endl;

		AddNewClient(ClientData);
		GoBackToMainMenu(choice);
		MainMenuScreen(choice);
		break;

	case enMainMenuScreen::DeleteClient:

		cout << "=====================================" << endl;
		cout << "\tDelete Clinets Screen" << endl;
		cout << "=====================================" << endl;

		cout << "Delete Clients :" << endl << endl;
		
		accountNumber = ReadString("Enter Account Number ? ");

		ReadDataFromFileToVector(fileName, vFileContent);

		lineData = FindClientData(accountNumber, ClientData);

		DeleteClientFromFile(accountNumber, ClientData, fileName, vFileContent, lineData);
		PrintClientData(accountNumber, ClientData);

		GoBackToMainMenu(choice);
		MainMenuScreen(choice);
		break;

	case enMainMenuScreen::UpdateClient:

		accountNumber = ReadString("Enter Account Number ? ");

		lineData = FindClientData(accountNumber, ClientData);
		ReadDataFromFileToVector(fileName, vFileContent);
		PrintClientData(accountNumber, ClientData);
		UpdateClinetData(ClientData, "#//#", fileName, vFileContent, lineData);

		GoBackToMainMenu(choice);
		MainMenuScreen(choice);
		break;

	case enMainMenuScreen::FindClient:

		accountNumber = ReadString("Enter Account Number ? ");
		ClientData = GetClientData(accountNumber);

		PrintClientData(accountNumber, ClientData);

		GoBackToMainMenu(choice);
		MainMenuScreen(choice);
		break;

	case enMainMenuScreen::Exit:
		ExitApp();
		break;

	default:
		system("cls");
		cout << "\nPlz enter a number between [1 to 6] ? " << endl;
		cin >> choice;
		MainMenuScreen(choice);
	}
}

int main()
{
	short choice = 0;

	system("cls");
	cout << "=====================================" << endl;
	cout << "\t    Main Menu Screen" << endl;
	cout << "=====================================" << endl;

	cout << "\t[1] Show Client List." << endl;
	cout << "\t[2] Add New Client." << endl;
	cout << "\t[3] Delete Client." << endl;
	cout << "\t[4] Update Client." << endl;
	cout << "\t[5] Find Client." << endl;
	cout << "\t[6] Exit." << endl;

	cout << "=====================================" << endl;
	cout << "Choose what do you want to do ? [1 to 6] ? ";
	cin >> choice;
	cout << endl;

	MainMenuScreen(choice);

	return 0;
}