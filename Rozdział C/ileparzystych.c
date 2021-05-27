#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int IleParzystych(int* elementy, int n) {

	int licznik = 0;
	for (int i = 0; i < n; i++)
	{
		if (elementy[i]%2==0)licznik++;
	}
	return licznik;
}