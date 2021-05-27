#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

void WypiszBitowo(unsigned short liczba) {

	unsigned short start = 1 << 15; //maska
	for (unsigned i = 1; i <= 16; i++)
	{
		printf("%c", liczba & start ? '1' : '0');
		liczba <<= 1;
		if (i % 4 == 0)printf(" "); //dzielenie ciagu po 4 bity
	}
	printf("\n");
}

void ZamienWartoscBitu(unsigned short liczba, unsigned short n) {

	liczba ^= 1 << n - 1;
	WypiszBitowo(liczba);
}

void Zamien(unsigned short liczba) {

	for (int i = 1; i <= 16; i++)
	{
		liczba ^= 1 << i - 1;
	}
	WypiszBitowo(liczba);
}

void ZamienPrzedzial(unsigned short liczba, int start, int koniec) {

	for (int i = start; i <= koniec; i++)
	{
		liczba ^= 1 << i - 1;
	}
	WypiszBitowo(liczba);

}

void ROR(unsigned short liczba, int n) {

	n %= 16;
	liczba = (liczba >> n) | (liczba << (16-n));
	WypiszBitowo(liczba);
}


void main() {

	printf("1. Zamien Wartosc Bitu \n");
	unsigned short liczba, n;
	printf("Podaj liczbe: ");
	scanf("%hu", &liczba);
	WypiszBitowo(liczba);
	printf("Podaj bit do zmiany n: "); //n={1..16}
	scanf("%hu", &n);
	ZamienWartoscBitu(liczba, n);


	printf("\n2. Zamien \n");
	printf("Podaj liczbe: ");
	unsigned short liczba2;
	scanf("%hu", &liczba2);
	WypiszBitowo(liczba2);
	Zamien(liczba2);

	printf("\n3. ZamienPrzedzial \n");
	printf("Podaj liczbe: ");
	unsigned short liczba3, start, koniec;
	scanf("%hu", &liczba3);
	WypiszBitowo(liczba3);
	printf("Podaj poczatek przedzialu: ");
	scanf("%hu", &start);
	printf("Podaj koniec przedzialu: ");
	scanf("%hu", &koniec);
	ZamienPrzedzial(liczba3, start, koniec);

	printf("\n4. ROR \n");
	printf("Podaj liczbe: ");
	unsigned short liczba4, n2;
	scanf("%hu", &liczba4);
	printf("Podaj przesuniecie: ");
	scanf("%hu", &n2);
	WypiszBitowo(liczba4);
	ROR(liczba4, n2);

}