#include <stdio.h>
#include <locale.h>

main () 
{
	setlocale(LC_ALL, "Turkish");
	char ad[0];
	printf("Ýsim Giriniz: ");
	//scanf("%5s", &ad);
	gets(ad); //Enter Tuþu Basýlana Kadar Herþeyi Alýr.
	printf("Ýsminiz: %s",ad);
	printf("\n");
	puts(ad); //Deðiþkenin Ýçeriðini Ekrana Yazar.
	getch();
}
