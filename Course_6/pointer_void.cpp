#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;


int main()
{	
	void* ptr;// Genreic Pointer

	float f1 = 1.5;
	int x1 = 50;

	ptr = &f1;

	cout << ptr << endl;
	cout << *(static_cast<float*>(ptr)) << endl;

	cout << endl;

	ptr = &x1;

	cout << ptr << endl;
	cout << *(static_cast<int*>(ptr)) << endl;

	return 0;
}

