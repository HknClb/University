#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>

main () {
	setlocale(LC_ALL, "Turkish");
	int a;
	int sayac = 0;
	gel1:
	srand(time(NULL));
	a = 1 +rand()%20;
	int b;
gel:
	printf("Tahmin Giriniz: ");
	scanf("%d", &b);
	if (a == b)
		printf("Tebrikler Buldun");
	else
	{
		sayac++;
		if (sayac >= 10)
		{
			printf("Sayý Deðiþti Geçen Sayý %d",a);
			sayac = 0;
			goto gel1;
		}
		else
			goto gel;
	}
	getch();
}
