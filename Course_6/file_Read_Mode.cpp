#include <iostream>
#include <fstream>
#include <string>

using namespace std;

void PrintFileContent(string fileName) 
{
	fstream MyFile;

	MyFile.open(fileName, ios::in);// Read mode

	if (MyFile.is_open()) 
	{
		string line;

		while (getline(MyFile, line))
		{

			cout << line << endl;

		}

		MyFile.close();
	}

}

int main()
{
	PrintFileContent("MyFile.txt");

	return 0;
}
