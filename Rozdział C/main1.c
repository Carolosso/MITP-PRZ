#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int ZnajdzIndeks(int* liczby, int element, int n)
{
	int indeks = 0;
	for (int i = 0; i < n; i++)
	{
		if (liczby[i] == element)
		{
			return i;
		}
		else
		{
			indeks = -1;
		}
	}
	return indeks;
}
int LiczbaCyfr(int liczba)
{
	int licznik = 0;
	if (liczba > 0)
	{
		for (int i = 0; liczba != 0; i++)
		{
			liczba = liczba / 10;
			licznik++;
		}
		return licznik;
	}
	return 1;
}

void WypiszKwadratyCyfr(int liczba) {

	int tmp = liczba;
	int licz;
	int n = LiczbaCyfr(tmp);
	for (int i = n ; i > 0; i--)
	{
		for (n; n > 0; n--)
		{
			licz = pow((tmp / pow(10, n - 1)), 2);
			printf("%d\n",licz);

			int potega = pow(10, n - 1);
			tmp = tmp % potega;
		}
	}
	
}


//main
void main() {

	int sw;
	printf("Wybierz funkcje:\n");
	printf("1: ZnajdzIndeks\n");
	printf("2: LiczbCyfr\n");
	printf("3: Wypisz kwadraty cyfr \n");
	scanf("%i", &sw);

	int tmp = 0, element = 0;
	int n = 0;
	int liczba = 0;
	switch (sw)
	{
	case 1:
		system("cls");
		printf("Wybrales funkcje 1: ZnajdzIndeks\n");
		printf("Ile elementow chcesz wprowadzic? ");
		scanf("%i", &n);
		printf("Podaj kolejne elementy: \n");
		int* liczby = (int*)malloc(sizeof(int) * n);
		for (int i = 0; i < n; i++)
		{
			scanf("%i", &tmp);
			liczby[i] = tmp;
		}
		printf("Ktora liczbe chcesz znalezc? ");
		scanf("%i", &element);
		printf("\nLiczba %i znajduje sie na ideksie %i. \n",element, ZnajdzIndeks(liczby, element, n));
		break;

	case 2:
		system("cls");
		printf("Wybrales funkcje 2: LiczbaCyfr\n");
		printf("Podaj liczbe: ");
		scanf("%i", &liczba);
		printf("\nLiczba cyfr w liczbie %i wynosi: %i \n",liczba, LiczbaCyfr(liczba));
		break;

	case 3:
		system("cls");
		printf("Wybrales funkcje 3: WypiszKwadratyCyfr\n");
		printf("Podaj liczbe: ");
		scanf("%i", &liczba);
		WypiszKwadratyCyfr(liczba);
		break;
	default:
		break;
	}


}
