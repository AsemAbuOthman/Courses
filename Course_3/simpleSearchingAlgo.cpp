#include <iostream>
#include <string>

using namespace std;

int main()
{
	int arr[10] = {10,5,6,7,50,20,88,61,55,100};

	for (int i = 0; i < 10; i++)
	{
		if (arr[i] == 20) 
		{
			cout << i + 1 << endl;
			break;
		}
			
	}

	return 0;
}