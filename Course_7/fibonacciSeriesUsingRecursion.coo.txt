#include <iostream>
using namespace std;

void PrintFibonacciNumbersUsingRecursion(short number, int prev1, int prev2)
{
	int fibonacciNumber = 0;

	if (number > 0) 
	{
		fibonacciNumber = prev1 + prev2;
		prev2 = prev1;
		prev1 = fibonacciNumber;
		cout << fibonacciNumber << " ";

		PrintFibonacciNumbersUsingRecursion(number - 1, prev1, prev2);
	}

}


int main()
{
	PrintFibonacciNumbersUsingRecursion(11, 0, 1);
	

	return 0;
}