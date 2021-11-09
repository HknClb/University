#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL, "Turkish");
	//Üçgen'in alaný = (taban * yükseklik)/2
	int bot, h, alan;
	printf("Alaný hesaplanacak üçgenin tabanýný ve yüksekliðini giriniz: ");
	scanf("%d %d", &bot, &h);
	alan = (bot * h) / 2;
	printf("Girilen üçgenin alaný = %d", alan);
	getch();	
}
