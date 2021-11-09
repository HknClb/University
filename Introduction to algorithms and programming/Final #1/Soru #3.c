#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int i;
	int bassay = 0;
	int sayi;
	int kont;
	int top;
	don:
	kont = 1;
	top = 0;
	bassay = 0;
	printf("Sayýyý Giriniz: ");
	scanf("%d", &sayi);
	int gec = sayi;
	
	while(kont != 0)
	{
		kont = gec / 10;
		gec /= 10;
		bassay++;
	}
	gec = sayi;
	for(i = 0; i < bassay; i++)
	{
		top += sayi % 10;
		sayi /= 10;
	}
	printf("\t\tq%d Sayýsýnýn Basamaklarý Toplamý = %d\n", gec, top);
	goto don;
	getch();
}
