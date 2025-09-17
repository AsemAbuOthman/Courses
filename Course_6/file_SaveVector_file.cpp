#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

void SaveVectorToFile(string fileName, vector<string>& vNames)
{
	fstream MyFile;

	MyFile.open(fileName, ios::out | ios::app);

	if (MyFile.is_open()) 
	{
	
		for (string &line : vNames) 
		{
		
			if (line != "")
			{
				MyFile << line << endl;
			}
		}
		
		MyFile.close();
	}

}

int main()
{
	vector <string> vNames = {"Sammer", "Ahmad", "Mona", "Sarah"};

	SaveVectorToFile("MyFile.txt", vNames);

	return 0;
}
