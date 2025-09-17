#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	fstream MyFile;

	MyFile.open("MyFile.txt", ios::out | ios::app);// Write modes

		if (MyFile.is_open())
		{
			MyFile << "Hi, again this my last chance to study before breakfast !" << endl;
			MyFile << "Good bye!" << endl;
		
			MyFile.close();
		}

	return 0;
}
