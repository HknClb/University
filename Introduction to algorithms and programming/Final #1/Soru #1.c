#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
Switch case de char oldu�u i�in yanl��. -5                       
Y�lda sadece kat�n� buldu�um toplamad���m i�in yanl��. -5
Basamak say�s�nda kontu da b�lmedi�im i�in yanl��. -10
f(x)'de 6 ve 9 i�in de�eri 6 verdi�im i�in yaln��. -5
Ekran ��kt�s�nda c yerine 20 yazd���m i�in yaln��. -7

*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	char mevsim[10] = "NULL";
	char yaz = "Yaz";
	char kis = "K��";
	char ilkbahar = "�lkbahar";
	char sonbahar = "Sonbahar";
	don:
	printf("Mevsim Girin: ");
	scanf(" %s", mevsim);
	printf("%s", mevsim);
	
	switch((char)mevsim)
	{
		case (char)yaz:
			printf("Haziran, Temmuz, A�ustos");
			break;
		case (char)kis:
			printf("Aral�k, Ocak, �ubat");
			break;	
		case (char)ilkbahar:
			printf("Mart, Nisan, May�s");
			break;
		case (char)sonbahar:
			printf("Eyl�l, Ekik, Kas�m");
			break;
		default:
			printf("L�tfen Ge�erli Mevsim Girin.\n");
			goto don;
			break;
	}
	getch();
}
