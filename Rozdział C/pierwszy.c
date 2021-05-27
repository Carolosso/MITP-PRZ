#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

void main() {

	int liczba;
	printf("Podaj liczbe: ");
	scanf("%d",&liczba);
	char napis[] = "TEstowe zdaniesa:,.asd";
	int i = 0;
	int dlugosc = 0;
	while (napis[i]!=0)
	{
		dlugosc++;
		i++;
	}
	printf("%d",dlugosc);

}