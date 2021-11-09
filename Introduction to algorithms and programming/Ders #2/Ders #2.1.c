#include <stdio.h>
#include <locale.h>

main () {
	setlocale(LC_ALL, "Turkish");
	int a, b, top, cikar, carp, bol, kal;
	printf("Ýlk Sayýyý Giriniz: ");
	scanf("%d", &a);
	printf("Ýkinci Sayýyý Giriniz: ");
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
	printf("Toplam: %d Çýkarma: %d Çarpma: %d Bölme: %d Kalan: %d", top, cikar, carp, bol, kal);
	getch();
}
