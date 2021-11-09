#include <stdio.h>
#include <locale.h>

main () {
	setlocale(LC_ALL, "Turkish");
	int yas;
	float boy;
	char ad[20];
	printf("Ýsminiz Yaþýnýz Ve Boyunuzu Aralarýnda Boþluk Býrakarak Giriniz: ");
	scanf("%s %d %f", ad, &yas, &boy);
	printf("Ýsim: %s Yaþ: %d Boy: %1.2f", ad, yas, boy); //&1.2f --> Ekrana virgülden önce 1 virgülden sonraki 2 basamaðý yazdýrýr.
	getch();
}
