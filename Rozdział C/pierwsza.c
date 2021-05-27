#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

void pierwsza(int m) {

	if (m > 1)
	{
		if (m == 2)
		{
			printf("TAK");
		}
		else
		{
			if (m % 2 == 0)
			{
				printf("NIE");
				exit(0);
			}
			else
			{
				int k = sqrt(m);
				int i = 3;

				while (i <= k)
				{
					if (m % i == 0)
					{
						printf("NIE");
						exit(0);
					}
					else i += 2;
				}
				printf("TAK");
				exit(0);
			}
		}
	}
	else printf("Bledne dane!");
	exit(0);
}

void main() {

	int m;
	printf("Podaj m: ");
	scanf("%d", &m);
	pierwsza(m);
}