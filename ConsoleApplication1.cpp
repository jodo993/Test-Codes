// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;


int main()
{
	for (int i = 1; i <= 100; i++)
	{
		if (i % 3 == 0)
			cout << "fizz ";
		else if (i % 5 == 0)
			cout << "buzz ";
		else
			cout << i;
		cout << endl;
	}
    return 0;
}

