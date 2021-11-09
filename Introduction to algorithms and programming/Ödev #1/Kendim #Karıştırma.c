#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <string.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	char sayilar[10];
	int gecici;
	int a;
	int i;
	for(i = 0; i < 10; i++)
	{
		printf("%d. Sayý Giriniz: ", i + 1);
		scanf("%d", &a);
		sayilar[i] = a;
	}
	printf("\n");
	for(i = 0; i < 10; i++)
	{
		a = sayilar[i];
		printf("%d ", a);
	}
	int rast;
	srand(time(NULL));
	printf("\n \n");
	for(i = 0; i < 10; i++)
	{
		rast = rand() % 10;
		gecici = sayilar[i];
		a = sayilar[rast];
		sayilar[i] = a;
		sayilar[rast] = gecici;		
	}
	for(i = 0; i < 10; i++)
	{
		a = sayilar[i];
		printf("%d ", a);
	}
	getch();
}
