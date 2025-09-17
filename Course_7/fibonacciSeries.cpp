#include <iostream>
using namespace std;

void PrintFibonacciNumbers(int number)
{
	int fibonacciNumber = 0;
	int prev1 = 0, prev2 = 1;

	for (short i = 2; i <= number; i++) 
	{
		fibonacciNumber = prev1 + prev2;
		cout << fibonacciNumber << " ";
		prev2 = prev1;
		prev1 = fibonacciNumber;
	}

	cout << endl;

}


int main()
{
	PrintFibonacciNumbers(11);

	return 0;
}