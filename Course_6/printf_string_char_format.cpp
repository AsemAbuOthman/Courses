#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>
#include <cstdio>

using namespace std;

int main()
{
	char name[] = "Asem Abu Othman";
	char unversityName[] = "Unversity of jordan";

	printf("My name is : %s \n", name);
	printf("My unversity is : %s \n", unversityName);

	char c = 'A';
	printf("\nSetting the width of c : %*c\n", 5, c);
	printf("Setting the width of c : %*c\n", 4, c);
	printf("Setting the width of c : %*c\n", 3, c);
	printf("Setting the width of c : %*c\n", 2, c);
	printf("Setting the width of c : %*c\n\n", 1, c);

	// A shape

	printf("%*c \n", 5, c);

	printf("%*c ", 4, c);
	printf("%*c \n", 1, c);

	printf("%*c ", 3, c);
	printf("%*c \n", 3, c);


	printf("%*c ", 2, c);
	printf("%*c ", 2, c);
	printf("%*c \n", 2, c);

	printf("%*c ", 1, c);
	printf("%*c \n\n", 7, c);






	return 0;
}

