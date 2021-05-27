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

FILE* fp;

void DodajStudenta(char* i, char* n, int w, int nr) {

	if (tablica.aktualny < 20)
	{
		tablica.studenci[tablica.aktualny].imie = malloc(strlen(i) + 1);
		strcpy(tablica.studenci[tablica.aktualny].imie, i);
	
		tablica.studenci[tablica.aktualny].nazwisko = malloc(strlen(n) + 1);
		strcpy(tablica.studenci[tablica.aktualny].nazwisko, n);

		tablica.studenci[tablica.aktualny].wiek = w;
		tablica.studenci[tablica.aktualny].nrIndeksu = nr;
		
		tablica.aktualny++;
	}
	else printf("Brak miejsca w tablicy!\n\n");
	
}

void WypiszDane() {
	printf("\nLp.| Imie | Nazwisko | Wiek | nr Indeksu |\n\n");
	for (int i = 0; i < tablica.aktualny; i++)
	{
		printf("%d | %s | %s | %d | %d |\n",
			i,
			tablica.studenci[i].imie,
			tablica.studenci[i].nazwisko,
			tablica.studenci[i].wiek,
			tablica.studenci[i].nrIndeksu);
	}
	printf("\n");

}

int UsunPoNazwisku(char* naz) {

	int usunieto = 0; int zwracane = 0;

	for (int i = 0; i < tablica.aktualny; i++)
	{
		if (strcmp(tablica.studenci[i].nazwisko, naz) == 0) {
			free(tablica.studenci[i].imie);
			free(tablica.studenci[i].nazwisko);
			usunieto = 1;
			zwracane = i;
		}
	}
	if (usunieto == 1)
	{
		tablica.aktualny--;
		for (int i = zwracane + 1; i < 20; i++)
		{
			tablica.studenci[i - 1] = tablica.studenci[i];
		}
	}
	if (zwracane == 0)return -1;
	else return zwracane;
}

int WyszukajPoNrInd(int nr) {

	for (int i = 0; i < 20; i++)
	{
		if (tablica.studenci[i].nrIndeksu == nr) return i;
	}
	return -1;
}

void ZapiszDoPliku() {

	fp = fopen("plik.txt", "w");
	if (fp == NULL) {
		printf("Blad zapisu pliku.\n");
		return 0;
	}
	for (int i = 0; i < tablica.aktualny; i++)
	{
		fprintf(fp, "%s;%s;%d;%d\n",
			tablica.studenci[i].imie,
			tablica.studenci[i].nazwisko,
			tablica.studenci[i].wiek,
			tablica.studenci[i].nrIndeksu);
	}
	fclose(fp);
	printf("Plik zapisany pomyslnie!\n");
}

void OdczytajZPliku() {

	tablica.aktualny = 0;
	char linia[50];
	char** tab[4];
	fp = fopen("plik.txt", "r");

	if (fp == NULL) {
		printf("Blad odczytu pliku!\n");
		return 0;
	}

	int i = 0;

	while (fgets(linia, 50, fp))
	{
		char* podzielone;

		podzielone = strtok(linia, ";");
		tab[0] = malloc(strlen(podzielone) + 1);
		strcpy(tab[0], podzielone);
		tablica.studenci[i].imie = tab[0];

		podzielone = strtok(NULL, ";");
		tab[1] = malloc(strlen(podzielone) + 1);
		strcpy(tab[1], podzielone);
		tablica.studenci[i].nazwisko = tab[1];

		podzielone = strtok(NULL, ";");
		tab[2] = malloc(strlen(podzielone) + 1);
		strcpy(tab[2], podzielone);
		tablica.studenci[i].wiek = atoi(tab[2]);

		podzielone = strtok(NULL, ";");
		tab[3] = malloc(strlen(podzielone) + 1);
		strcpy(tab[3], podzielone);
		tablica.studenci[i].nrIndeksu = atoi(tab[3]);

		////sprawdzenie  
		//printf("%d | %s | %s | %d | %d |\n",
		//	i, 
		//	tablica.studenci[i].imie,
		//	tablica.studenci[i].nazwisko,
		//	tablica.studenci[i].wiek,
		//	tablica.studenci[i].nrIndeksu);
		tablica.aktualny++;
		i++;

	}
	fclose(fp);
	printf("Plik odczytany pomyslnie!\n");
}

void Wypelnienie() {
	char* puste; char puste_tab[] = "puste";
	puste = malloc(strlen(puste_tab) + 1); strcpy(puste, puste_tab);
	for (int i = 0; i < 20; i++)
	{
		tablica.studenci[i].imie = puste;
		tablica.studenci[i].nazwisko = puste;
		tablica.studenci[i].wiek = 0;
		tablica.studenci[i].nrIndeksu = 0;
	}
	free(puste);
}

void ZwolnieniePamieci() {

	for (int i = 0; i < tablica.aktualny; i++)
	{
		free(tablica.studenci[i].imie);
		free(tablica.studenci[i].nazwisko);
	}
	tablica.aktualny = 0;
}

void main() {

	//Wypelnienie();
	tablica.aktualny = 0;
	int wybor = 1;
	while (wybor != 0)
	{
		system("cls");
		printf("****MENU****\n");
		printf("1. Dodawanie kolejnego studenta do tablicy.\n");
		printf("2. Wypisanie danych wszystkich elementow tablicy.\n");
		printf("3. Usuwanie studenta po nazwisku.\n\n");
		printf("4. Wyszukaj po numerze indeksu.\n");
		printf("5. Zapisz do pliku.\n");
		printf("6. Odczytaj z pliku.\n");
		printf("0. Wyjscie\n");
		printf("************\n"); printf("Podaj opcje: "); scanf("%d", &wybor);
		switch (wybor)
		{
		case 1: {
			system("cls");
			char i[20]; char n[20]; int w, nr;
			printf("1. Dodawanie kolejnego studenta do tablicy.\n\n");
			printf("Podaj imie: \n"); scanf("%s", &i);
			printf("Podaj nazwisko: \n"); scanf("%s", &n);
			printf("Podaj wiek: \n"); scanf("%d", &w);
			printf("Podaj numer indeksu: \n"); scanf("%d", &nr);
			DodajStudenta(i, n, w, nr);
			system("pause");
			break;
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
			strcpy(naz, naz_tab);
			printf("\n%d\n", UsunPoNazwisku(naz));
			system("pause");
			break;
		}
		case 4: {
			system("cls");
			int nr;
			printf("4. Wyszukaj po numerze indeksu.\n");
			printf("Podaj numer indeksu: "); scanf("%d", &nr);
			printf("%d", WyszukajPoNrInd(nr));
			system("pause");
			break;
		}
		case 5: {
			system("cls");
			printf("5. Zapisz do pliku.\n");
			ZapiszDoPliku();
			system("pause");
			break;

		}case 6: {
			system("cls");
			printf("6. Odczytaj z pliku.\n");
			ZwolnieniePamieci();
			OdczytajZPliku();
			system("pause");
			break;
		}
		default:
			break;
		}
	}
}
