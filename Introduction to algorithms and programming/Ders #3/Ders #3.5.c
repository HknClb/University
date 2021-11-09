#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	long int a, sayac, b;
	printf("Sayý Giriniz: ");
	scanf("%d", &a);
	b = a;
	do
	{
		sayac++;
		a /= 10;
	}while(a > 0);
	printf("%d Sayýsý %d Basamaklýdýr", b, sayac);
	getch();
}
