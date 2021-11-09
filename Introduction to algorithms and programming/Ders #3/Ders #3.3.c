#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	int sayac;
	int sayi;
	int gec;
	printf("Faktoriyeli Hesaplanacak Sayýyý Giriniz: ");
	scanf("%d", &sayi);
	sayac = sayi;
	gec = sayi;
	while(sayac > 1)
	{
		sayac--;
		sayi *= sayac;
	}
	printf("%d! = %d", gec, sayi);
	getch();
}
