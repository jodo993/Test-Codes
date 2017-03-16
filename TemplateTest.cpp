// TemplateTest.cpp : Defines the entry point for the console application.
//
#include "Header.h"
#include "stdafx.h"
#include <iostream>

//#include "TemplateTest.h"
using namespace std;

int main()
{
	PairOf <WhichIsBigger> n;
	int one = 3;
	int other = 5;
	int z = 0;
	z = n.WhichIsBigger(one, other);
	cout << z << endl;
    return 0;
}

