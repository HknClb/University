#include <stdio.h>
#include <locale.h>

main () 
{
	setlocale(LC_ALL, "Turkish");
	char ad[0];
	printf("�sim Giriniz: ");
	//scanf("%5s", &ad);
	gets(ad); //Enter Tu�u Bas�lana Kadar Her�eyi Al�r.
	printf("�sminiz: %s",ad);
	printf("\n");
	puts(ad); //De�i�kenin ��eri�ini Ekrana Yazar.
	getch();
}
