#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>
#include <cstdio>

using namespace std;

int main()
{
	float pi = 3.14159265;

	printf("PI value is : %f \n\n", pi);

	printf("Precision specification of %.*f \n", 1, pi);
	printf("Precision specification of %.*f \n", 2, pi);
	printf("Precision specification of %.*f \n", 3, pi);
	printf("Precision specification of %.*f \n", 4, pi);

	float num1 = 7.0, num2 = 9.0;
	printf("\nThe float division is : %.3f / %.3f = %.3f\n", num1, num2, num1 / num2);
	
	double num = 12.45;
	printf("\nPrecision specification of %.3f \n ", num);
	printf("Precision specification of %.4f \n ", num);


	return 0;
}

