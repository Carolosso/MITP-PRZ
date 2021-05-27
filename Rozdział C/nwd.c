#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

void main() {

	int a, b;
	printf("Podaj a: ");
	scanf("%d", &a);
	printf("Podaj b: ");
	scanf("%d", &b);
	int r = 1;
	if (a > 0 || b > 0) {
		do {
			r = a % b;
			a = b;
			b = r;
		} while (r != 0);
		printf("NWD jest rowny: %d", a);
	}
	else printf("Bledne dane!");

}