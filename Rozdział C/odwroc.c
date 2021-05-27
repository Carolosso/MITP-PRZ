#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

void Odwroc(char* lancuch) {

    char wynik[1000];
    int start, koniec, dl = 0;

    //obliczanie dlugosci
    while (lancuch[dl] != '\0')dl++;
        

    koniec = dl - 1;

    for (start = 0; start < dl; start++) {
        wynik[start] = lancuch[koniec];
        koniec--;
    }
    wynik[start] = '\0';
    printf("%s\n", wynik);

}