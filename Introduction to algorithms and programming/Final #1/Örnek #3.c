#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

int main()
{
	//Üçgenin alaný = a kenarý * b kenarý * arada kalan açýnýn sinüsü.
	//Program dili açýyý radyan cinsinden alýr bu yüzden girilen açý radyana çevrilmek zorundadýr pi sayýsý ise math.h
	//kütüphanesinin elemaný olan M_PI olarak alýnýr ve sinüs de ayný þekildedir.
	setlocale(LC_ALL, "Turkish");
	float alan, der, a, b, rad;
	printf("Ýlk kenar ikinci kenar ve aradaki açýyý giriniz: ");
	scanf("%f %f %f", &a, &b, &der);
	rad = (der / 180) * M_PI;
	alan = a * b * sin(rad);
	printf("Üçgenin alaný = %5.2f", alan);
	getch();
}
