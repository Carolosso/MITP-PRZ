#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

void Podzielniki(int liczba) {

	if (liczba > 0)
	{
		for (int i = 1; i <= liczba; i++)
		{
			if (liczba % i == 0)
			{
				printf("%i \n", i);
			}
		}
	}
	else printf("Liczba jest mniejsza od 1");

}

double Srednia(double* X, int n) {

	double wynik = 0.0;
	double iloczyn = 1.0;
	for (int i = 0; i < n; i++)
	{
		iloczyn *= X[i];
	}
	wynik = pow(iloczyn, 1.0 / n);
	return wynik;
}
int Zamien(int l, int p, int zapis[]) {
	int i = 0;
	while (l!=0)
	{
		zapis[i] = l % p;
		l /= p;
		i++;
	}
	//wypisywanie od tylu
	for ( i = i - 1; i >= 0; i--)
	{
		printf("%d", zapis[i]);
	}
	return 0;
}
//main
void main_old() {

	int sw;
	printf("Wybierz opcje:\n");
	printf("1: Wypisz podzielniki liczby\n");
	printf("2: Srednia geometryczna\n");
	printf("3: Zamien na system \n");
	scanf("%i", &sw);

	double* elementy;
	int n=0, p=0, l=0;
	int liczba;
	double tmp = 0.0;
	int zapis[20];
	switch (sw)
	{

	case 1:
		system("cls");
		printf("Wybrales opcje 1: Wypisz podzielniki liczby\n");
		printf("Podaj liczbe: \n");
		scanf("%i", &liczba);
		Podzielniki(liczba);
		break;
	case 2:
		system("cls");
		printf("Wybrales opcje 2: Srednia geometryczna\n");
		printf("Ile elementow chcesz wprowadzic? ");
		scanf("%i", &n);
		printf("Podaj kolejne elementy: \n");
		elementy = (double*)malloc(sizeof(double) * n);
		for (int i = 0; i < n; i++)
		{
			scanf("%lf", &tmp);
			elementy[i] = tmp;
		}
		printf("Srednia geometyczna liczba wynosi: %f \n", Srednia(elementy, n));
		break;
	case 3:
		system("cls");
		printf("Wybrales opcje 3: Zamien liczbe na system\n");
		printf("Podaj liczbe ktora chcesz zamienic:  ");
		scanf("%i", &l);
		printf("Podaj system liczbowy:  \n");
		scanf("%i", &p);
		printf("Liczba %d zamieniona na system liczbowy o podstawie %d to: ", l, p); Zamien(l, p, zapis);
		printf("\n");
		break;
	default:
		break;
	}

	
}
