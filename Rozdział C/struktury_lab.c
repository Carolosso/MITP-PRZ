#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Student {
	char* imie;
	char* nazwisko;
	int wiek;
	int nrIndeksu;
};
struct Tablica {
	int aktualny;
	struct Student studenci[20];
};
struct Tablica tablica;

void DodajStudenta(char* i, char* n, int w, int nr) {

	tablica.studenci[tablica.aktualny].imie = i;
	tablica.studenci[tablica.aktualny].nazwisko = n;
	tablica.studenci[tablica.aktualny].wiek = w;
	tablica.studenci[tablica.aktualny].nrIndeksu = nr;
}

void WypiszDane() {
	printf("Lp.| Imie | Nazwisko | Wiek | nr Indeksu |.\n");
	for (int i = 0; i < 20; i++)
	{
		printf("%d | %s | %s | %d | %d |\n",i,
			tablica.studenci[i].imie,
			tablica.studenci[i].nazwisko,
			tablica.studenci[i].wiek,
			tablica.studenci[i].nrIndeksu);
	}
}

int UsunPoNazwisku(char* naz) {
	char* puste; char puste_tab[] = "puste";
	puste = malloc(strlen(puste_tab) + 1); strcpy(puste, puste_tab);
	for (int i = 0; i < 20; i++)
	{
		if (strcmp(tablica.studenci[i].nazwisko,naz)==0) {
			tablica.studenci[i].imie = puste;
			tablica.studenci[i].nazwisko = puste;
			tablica.studenci[i].wiek = 0;
			tablica.studenci[i].nrIndeksu = 0;
			return i;
		}
	}
	return -1;
}

void Wypelnienie() {
	char* puste; char puste_tab[] = "puste";
	puste= malloc(strlen(puste_tab) + 1); strcpy(puste, puste_tab);
	for (int i = 0; i < 20; i++)
	{
		tablica.studenci[i].imie = puste;
		tablica.studenci[i].nazwisko = puste;
		tablica.studenci[i].wiek = 0;
		tablica.studenci[i].nrIndeksu = 0;
	}
}
void main() {
	Wypelnienie();
	tablica.aktualny = 0;
	int wybor=1;
	while (wybor!=0)
	{
		system("cls");
		printf("****MENU****\n");
		printf("1. Dodawanie kolejnego studenta do tablicy.\n");
		printf("2. Wypisanie danych wszystkich elementow tablicy.\n");
		printf("3. Usuwanie studenta po nazwisku.\n");
		printf("0. Wyjscie\n");
		printf("************\n"); printf("Podaj opcje: "); scanf("%d", &wybor);
		switch (wybor)
		{
		case 1: {
			system("cls");
			char i_tab[20]; char n_tab[20];
			char* i; char* n; int w, nr;
			printf("1. Dodawanie kolejnego studenta do tablicy.\n\n");
			if (tablica.aktualny>19)
			{
				printf("Brak miejsca w tablicy!\n\n");
				system("pause");
				break;
			}
			else
			{
				printf("Podaj imie: \n"); scanf("%s", i_tab);
				printf("Podaj nazwisko: \n"); scanf("%s", n_tab);
				i = malloc(strlen(i_tab) + 1); n = malloc(strlen(n_tab) + 1);
				strcpy(i, i_tab); strcpy(n, n_tab);
				printf("Podaj wiek: \n"); scanf("%d", &w);
				printf("Podaj numer indeksu: \n"); scanf("%d", &nr);
				DodajStudenta(i, n, w, nr);
				tablica.aktualny++;
				system("pause");
				break;
			}
			
		}
		case 2: {
			system("cls");
			printf("2. Wypisanie danych wszystkich elementow tablicy.\n");
			WypiszDane();
			system("pause");
			break;
		}
		case 3: {
			system("cls");
			printf("3. Usuwanie studenta po nazwisku.\n");
			char naz_tab[20];
			char* naz;
			printf("Podaj nazwisko do usuniecia: \n"); scanf("%s", naz_tab);
			naz = malloc(strlen(naz_tab) + 1);
			strcpy(naz,naz_tab);
			printf("\n%d\n",UsunPoNazwisku(naz));
			system("pause");
			break;
		}
		default:
			break;
		}
	}
}
