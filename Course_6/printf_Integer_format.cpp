#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{
	int pageNum = 1, totalPageNumbers = 10;

	printf("Your page number is %d\n", pageNum);
	printf("Your page number is %d and total number of pages is %d\n", pageNum, totalPageNumbers);

	int num1 = 10, num2 = 20;
	printf("Your pages are %0*d \n", 3, pageNum);
	printf("The Result of %d + %d = %d \n", num1, num2, num1 + num2);

	return 0;
}

