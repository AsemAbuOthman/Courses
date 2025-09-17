#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

void ReadDataFromFileToVector(string fileName, vector <string>  &vFileContent)
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

int main()
{
	vector <string> vFileContent;

	ReadDataFromFileToVector("MyFile.txt", vFileContent);

	vector <string>::iterator iter;

	for (iter = vFileContent.begin(); iter != vFileContent.end(); iter++) 
	{
		cout << *iter << endl;
	}



	return 0;
}
