#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

//deklaracje funkcji
int IleParzystych(int* elementy, int n);
void Odwroc(char* lancuch);
void ZamienLitery(char* lancuch);
void Podzielniki(int liczba);
double Srednia(double* X, int n);
int Zamien(int l, int p, int zapis[]);

//main
void main() {

	int sw;
	printf("Wybierz opcje:\n");
	printf("1: Ile parzystych\n");
	printf("2: Odwroc\n");
	printf("3: Zamien litery\n");
	printf("4: Wypisz podzielniki liczby\n");
	printf("5: Srednia geometryczna\n");
	printf("6: Zamien \n");

	scanf("%i",&sw);

	int* elementy;	double* elementy_5;
	int n=0;	int n_5 = 0;
	int liczba_4;	int liczba_5;
	char* lancuch;	char* lancuch2;
	int tmp=0;	double tmp_5 = 0;
	char tablica[20];	char tablica2[20];
	switch (sw)
	{
	case 1:
		system("cls"); //clear console
		printf("Wybrales opcje 1: Ile parzystych\n");
		printf("Ile elementow chcesz wprowadzic? ");
		scanf("%i",&n);
		printf("Podaj kolejne elementy: \n");
		elementy = (int*)malloc(sizeof(int) * n);
		for (int i = 0; i < n; i++)
		{
			tmp = 0;
			scanf("%i",&tmp);
			elementy[i] = tmp;
		}
		printf("Liczb parzystych w zbiorze: %i \n", IleParzystych(elementy, n));
		break;
	case 2:
		system("cls");
		printf("Wybrales opcje 2: Odwroc\n");
		printf("Podaj wyraz: \n");
		scanf("%s", &tablica);
		lancuch = tablica;
		Odwroc(lancuch);
		break;
	case 3:
		system("cls");
		printf("Wybrales opcje 3: Zamien litery\n");
		printf("Podaj wyraz: \n");
		scanf("%s", &tablica2);
		lancuch2 = tablica2;
		ZamienLitery(lancuch2);
		break;
	case 4:
		system("cls");
		printf("Wybrales opcje 4: Wypisz podzielniki liczby\n");
		printf("Podaj liczbe: \n");
		scanf("%i", &liczba_4);
		Podzielniki(liczba_4);
		break;
	case 5:
		system("cls");
		printf("Wybrales opcje 5: Srednia geometryczna\n");
		printf("Ile elementow chcesz wprowadzic? ");
		scanf("%i", &n_5);
		printf("Podaj kolejne elementy: \n");
		elementy_5 = (double*)malloc(sizeof(double) * n_5);
		for (int i = 0; i < n_5; i++)
		{
			scanf("%lf", &tmp_5);
			elementy_5[i] = tmp_5;
		}
		printf("Srednia geometyczna liczba wynosi: %f \n", Srednia(elementy_5, n_5));
		break;
	case 0:
		/*system("cls");
		printf("Wybra³eœ opcje 1-Ile parzystych\n");*/
		break;
	default:
		break;
	}
}
