#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{	

	int* ptrX;// declare an int pointer in memory

	float* ptrY;// declare a float pointer in memory

	// allocate memory space for int & float
	ptrX = new int;
	ptrY = new float;

	// assign values to pointers
	*ptrX = 50;
	*ptrY = 100;

	// Use pointers as you Wish then

	cout << *ptrX << endl;
	cout << *ptrY << endl;

	cout << endl;

	cout << ptrX << endl;
	cout << ptrY << endl;

	// deallocate pointers from memory 

	delete ptrX;
	delete ptrY;

	return 0;//
}
