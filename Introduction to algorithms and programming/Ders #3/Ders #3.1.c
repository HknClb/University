#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	float a;
	float b;
	float c;
	float delta;
	float tekkok;
	float delkok;
	float x1;
	float x2;
	printf("ax2 +- bx +- c denkleminin a b c deðerlerini giriniz: ");
	scanf("%f %f %f", &a, &b, &c);
	//printf("%f %f %f", a, b, c);
	delta = (b * b) - (4 * a * c);
	if(delta < 0)
	{
		printf("Delta %3.2f Sýfýrdan Küçük Olduðu Ýçin Reel Kök Yoktur.", delta);
	}
	
	else if(delta == 0)
	{
		tekkok = -(b/(2*a));
		printf("Delta %3.2f Sýfýra Eþit Olduðu Ýçin Tek Kök Vardýr X1 = %3.2f", delta, tekkok);
	}
	
	else
	{
		delkok = sqrt(delta);
		x1 = (-b + delkok) / (2*a);
		x2 = (-b - delkok) / (2*a);
		printf("Delta %3.2f Sýfýrdan Büyük Olduðu Ýçin 2 Kök Vardýr X1 = %3.2f X2 = %3.2f", delta, x1, x2);
	}
	
	getch();
}
