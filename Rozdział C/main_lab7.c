#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

unsigned short IleBitowUnsignedShort() {

	return sizeof(unsigned short)*8;
}

void WypiszBitowo(unsigned short liczba) {

	if (liczba == 0) printf("0000 0000 0000 0000");
	else{

		unsigned short start = 1 << 15; //tworzymy tablice/maske przesuwajac 1 (0000 0000 0000 0001) o 15 bitow w lewo co da nam [1000000000000000]

		for (unsigned i = 1; i <= 16; i++)
		{
			printf("%c", liczba & start ? '1' : '0'); // ??
			liczba <<= 1;
			if (i % 4 == 0)printf(" "); //dzielenie ciagu po 4 bity
		}
	}
	printf("\n");
}

void PodstawoweOperacjeBitowe(unsigned short a, unsigned short b, unsigned short n) {

	printf("a: "); WypiszBitowo(a); printf("b: "); WypiszBitowo(b);

	unsigned short koniunkcja = a & b; //AND a&b
	printf("a&b: "); WypiszBitowo(koniunkcja);
	unsigned short alternatywa = a | b;//OR a|b
	printf("a|b: "); WypiszBitowo(alternatywa);
	unsigned short roznica_symetryczna = a ^ b; //XOR a^b
	printf("a^b: "); WypiszBitowo(roznica_symetryczna);
	unsigned short uzupelnienie = ~a; //uzupelnienie jedynkowe ~a
	printf("~a: "); WypiszBitowo(uzupelnienie);
	unsigned short lewo = a << n; //przesuniecie w lewo a<<n
	printf("a<<n: "); WypiszBitowo(lewo);
	unsigned short prawo = a >> n; //przesuniecie w prawo a>>n
	printf("a>>n: "); WypiszBitowo(prawo);

}

void UstawBitNa1(unsigned short liczba, unsigned short n) {

	liczba |= 1 << n;
	WypiszBitowo(liczba);
}

void main() {
	
	printf("1. Unsigned short bity:   %d \n", IleBitowUnsignedShort());
	unsigned short liczba;

	printf("2. Podaj liczbe: ");
	scanf("%hu", &liczba);
	WypiszBitowo(liczba);

	unsigned short a,b,n;
	printf("3. \n");
	printf("Podaj liczbe a: ");
	scanf("%hu", &a);
	printf("Podaj liczbe b: ");
	scanf("%hu", &b);
	printf("Podaj liczbe n: ");
	scanf("%hu", &n);
	printf("\n");
	PodstawoweOperacjeBitowe(a, b, n);

	printf("\n");
	printf("4. \n");
	unsigned short liczba2, n2;
	printf("Podaj liczbe: ");
	scanf("%hu", &liczba2);
	WypiszBitowo(liczba2);
	printf("Podaj bit do zmiany n: "); //n={0..15}
	scanf("%hu", &n2);
	UstawBitNa1(liczba2, n2);
}