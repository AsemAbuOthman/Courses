#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{
	float number = 0;
	string result = "";

	result = (number == 0) ? "Zero" : (number > 0) ? "Positive" : "Negative";

	cout << "Number is " << result << endl;

	return 0;
}
