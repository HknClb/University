#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL, "Turkish");
	//��gen'in alan� = (taban * y�kseklik)/2
	int bot, h, alan;
	printf("Alan� hesaplanacak ��genin taban�n� ve y�ksekli�ini giriniz: ");
	scanf("%d %d", &bot, &h);
	alan = (bot * h) / 2;
	printf("Girilen ��genin alan� = %d", alan);
	getch();	
}
