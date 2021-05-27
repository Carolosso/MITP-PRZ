#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <malloc.h>

int max(int* a, int n) {

	int max = a[0];
	int i = 1;
	while (i < n)
	{
		if (a[i] > max)	max = a[i];
		i++;
	}
	return max;
}

int main() {

	int n, i, * a;

	printf("Podaj n: "); scanf("%d", &n);
	if (n < 1) {
		printf("Bledne dane!");
		return 0;
	}
	a = malloc(sizeof(int) * n);
	if (a == NULL) {
		printf("BLAD!");
		return 0;
	}
	i = 0;
	do
	{
		printf("Podaj a[%d]: ", i + 1); scanf("%d", &a[i]);
		i++;
	} while (i < n);

	printf("MAX: %d", max(a, n));
	free(a);
}
