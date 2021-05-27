#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>

double Srednia(double* X, int n) {
	double wynik=0.0;
	double iloczyn = 1.0;
	for (int i = 0; i < n; i++)
	{
		iloczyn *=X[i];
	}
	wynik = pow(iloczyn, 1.0 / n);
	return wynik;
}