#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;


int main()
{	
	int arr[] = {10, 20, 30, 40};
	int* ptr;

	ptr = arr;

	cout << "Address of array elements : " << endl;
	cout << ptr << endl;
	cout << ptr + 1 << endl;
	cout << ptr + 2 << endl;
	cout << ptr + 3 << endl;

	cout << endl;

	cout << "Vlaues of array elements : " << endl;
	cout << *ptr << endl;
	cout << *(ptr + 1) << endl;
	cout << *(ptr + 2) << endl;
	cout << *(ptr + 3) << endl;


	return 0;
}
