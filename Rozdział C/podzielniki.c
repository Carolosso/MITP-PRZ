#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>


void Podzielniki(int liczba) {

	
	if (liczba > 0)
	{
		for (int i = 1; i <= liczba; i++)
		{
			if (liczba%i==0)
			{
				printf("%i \n",i);
			}
		}
	}
	else printf("Liczba jest mniejsza od 1");
	
}