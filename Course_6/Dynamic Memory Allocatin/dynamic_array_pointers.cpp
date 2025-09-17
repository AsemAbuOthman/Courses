#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{	

	float* ptr;
	int length;

	cout << "Enter how many students do you want to enter grades : ";
	cin >> length;

	// memory allocation for dynamic array
	ptr = new float[length];


	// Read students grade
	for (int i = 0; i < length; i++) 
	{
		cout << "Student " << i + 1  << " : ";
		cin >> *(ptr + i);
		cout << endl;
	}

	// Displaying for students grade 
	for (int i = 0; i < length; i++)
	{
		cout << "Student " << i + 1 << " grade is ";
		cout << *(ptr + i);
		cout << endl;
	}

	// Deallocate or Release of pointer array
	delete[] ptr;


	return 0;
}
