#include <stdio.h>
#include <locale.h>

main () {
	setlocale(LC_ALL, "Turkish");
	int yas;
	float boy;
	char ad[20];
	printf("�sminiz Ya��n�z Ve Boyunuzu Aralar�nda Bo�luk B�rakarak Giriniz: ");
	scanf("%s %d %f", ad, &yas, &boy);
	printf("�sim: %s Ya�: %d Boy: %1.2f", ad, yas, boy); //&1.2f --> Ekrana virg�lden �nce 1 virg�lden sonraki 2 basama�� yazd�r�r.
	getch();
}
