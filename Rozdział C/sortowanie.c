#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <malloc.h>

int main() {

	int n, i, j, k, pom, * a;
	
	printf("Podaj n: "); scanf("%d", &n);
	a = malloc(sizeof(int) * n);
	if (a == NULL) {
		printf("BLAD!");
		return 0;
	}
	
	i = 0;

	while (i < n)
	{
		printf("Podaj a[%d]: ", i + 1); scanf("%d", &a[i]);
		i++;
	}
	i = 0;

	while (i < n - 1)
	{
		j = i + 1;
		k = i;
		while (j < n)
		{
			if (a[j] < a[k]) k = j;
			j++;
		}
		pom = a[k];
		a[k] = a[i];
		a[i] = pom;
		i++;
	}

	i = 0;
	while (i < n)
	{
		printf("a[%d]: %d \n", i + 1, a[i]);
		i++;
	}
	free(a);
	return 0;
}