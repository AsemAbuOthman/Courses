#pragma once

#include <cmath>

namespace MyMathLib 
{
	float MyPow(float base, int exp)
	{
		float result = 1;

		if (exp == 0)
			return 1;

		for (int i = 1; i <= exp; i++) 
		{
			result *= base;
		}

		return result;
	}

	float MyAbs(float number) 
	{
		if (number < 0)
			return number * -1;

		return number;
	}

	int MyRound(float number) 
	{
		if (number > 0) 
		{
			if (number >= (int)number + 0.5)
				return (int)number + 1;
		}
		else if(number < 0)
		{
			if (number <= (int)number - 0.5)
				return (int)number - 1;
		}
		else
			return number;
	}

	int MyFloor(float number) 
	{
		if (number < 0 && number != (int)number)
			return number - 1;

		return number;
	}

	int MyCeil(float number) 
	{
		if (number != (int)number) 
		{
			if (number > 0)
				return number + 1;
		}

		return number;
	}

	float MySqrt(float number) 
	{
		return pow(number, 0.5);
	}
}