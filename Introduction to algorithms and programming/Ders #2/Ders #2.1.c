#include <stdio.h>
#include <locale.h>

main () {
	setlocale(LC_ALL, "Turkish");
	int a, b, top, cikar, carp, bol, kal;
	printf("�lk Say�y� Giriniz: ");
	scanf("%d", &a);
	printf("�kinci Say�y� Giriniz: ");
	scanf("%d", &b);
	top = a + b;
	if (a < b)
	{
		cikar = b - a;
		bol = b / a;
		kal = b % a;
	}
	else
	{
		cikar = a - b;
		bol = a / b;
		kal = a % b;
	}
	carp = a * b;
	printf("Toplam: %d ��karma: %d �arpma: %d B�lme: %d Kalan: %d", top, cikar, carp, bol, kal);
	getch();
}
