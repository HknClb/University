#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <string.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	int a, b, obeb, okek;
	gel:
	printf("Ýki Adet Sayý Giriniz: ");
	scanf("%d %d", &a, &b);
	int i = 0;
	if(a < b)
	{
		obeb = a;
		okek = b;
	}
	else if(b < a)
	{
		obeb = b;
		okek = a;
	}
	else
	{
		printf("Ýki Sayýda Eþittir Lütfen Tekrar Girin.\n");
		goto gel;
	}
	while(i == 0)
	{
		if(a % obeb == 0 && b % obeb == 0)
		{
			break;
			printf("a");
		}
		else
			obeb--;
	}
	while(i == 0)
	{
		if(okek % a == 0 && okek % b == 0)
		{
			break;
		}
		else
			okek++;
	}
	printf("Obeb: %d - Okek: %d", obeb, okek);
	getch();
}
