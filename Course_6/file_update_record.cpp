#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

void LoadDataFromFileToVector(string fileName, vector<string> &vFileContent) 
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

void SaveVectorToFile(string fileName, vector<string> vFileContent)
{
	fstream MyFile;

	MyFile.open(fileName, ios::out);

	if (MyFile.is_open()) 
	{
		for (string &line : vFileContent) 
		{
			if (line != "")
			{
				MyFile << line << endl;
			}
		}
		
		MyFile.close();
	}
}

void UpdateRecordFromFile(string fileName, string record, string updateTo) 
{
	vector <string> vFileContent;
	LoadDataFromFileToVector(fileName, vFileContent);

	for (string &line : vFileContent) 
	{
		if (line == record)
		{
			line = updateTo;
		}
	}


	SaveVectorToFile(fileName, vFileContent);
}

void PrintFileContent(string fileName) 
{
	fstream MyFile;
	vector<string> vFileName;
	

	MyFile.open(fileName, ios::in);

	if (MyFile.is_open()) 
	{
		string line;

		while (getline(MyFile, line)) 
		{
			cout << line << endl;
		}
	
	}
}

int main()
{
	vector <string> vFileContent;

	cout << "Before edit file : " << endl;
	PrintFileContent("MyFile.txt");
	
	UpdateRecordFromFile("MyFile.txt", "Walled", "Waheed");

	cout << "\n\nAfter edit file : " << endl;
	PrintFileContent("MyFile.txt");

	return 0;
}
