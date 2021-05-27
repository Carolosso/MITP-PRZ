#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <malloc.h>


void min_max(int n, double* a, double* min, double* max) {

	int i = 0;
	while (i < n - 1)
	{
		if (a[i] > a[i + 1])
		{
			double temp = a[i];
			a[i] = a[i + 1];
			a[i + 1] = temp;
		}
		i += 2;
	}
	*max = a[1];
	*min = a[0];
	i = 1;
	while (i < n)
	{
		if (a[i] > *max) *max = a[i];
		i += 2;
	}
	if (n % 2 == 1)
	{
		if (*max < a[i - 1]) *max = a[i - 1];
	}
	i = 0;
	while (i < n)
	{
		if (a[i] < *min) *min = a[i];
		i += 2;
	}
}

int main() {

	int n, i; double el, * a, min, max;
	printf("Podaj liczbe elementow: "); scanf("%d" ,&n);
	if (n < 2)
	{
		printf("Za mala liczba elementow! \n");
		return 0;
	}
	a = malloc(sizeof(double) * n);
	if (!a)
	{
		printf("Blad pamieci!");
		return 0;
	}
	i = 0;
	while (i < n)
	{
		printf("Podaj element %d: ", i + 1);
		scanf("%lf", &el);
		a[i] = el;
		i++;
	}
	min_max(n, a, &min, &max);
	printf("MAX: %f \nMIN: %f", max, min);
	free(a);
	return 0;
}