#include <stdio.h>
#include <conio.h>
#include <locale.h>

/*
Switch case de char olduðu için yanlýþ. -5                       
Yýlda sadece katýný bulduðum toplamadýðým için yanlýþ. -5
Basamak sayýsýnda kontu da bölmediðim için yanlýþ. -10
f(x)'de 6 ve 9 için deðeri 6 verdiðim için yalnýþ. -5
Ekran çýktýsýnda c yerine 20 yazdýðým için yalnýþ. -7

*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	char mevsim[10] = "NULL";
	char yaz = "Yaz";
	char kis = "Kýþ";
	char ilkbahar = "Ýlkbahar";
	char sonbahar = "Sonbahar";
	don:
	printf("Mevsim Girin: ");
	scanf(" %s", mevsim);
	printf("%s", mevsim);
	
	switch((char)mevsim)
	{
		case (char)yaz:
			printf("Haziran, Temmuz, Aðustos");
			break;
		case (char)kis:
			printf("Aralýk, Ocak, Þubat");
			break;	
		case (char)ilkbahar:
			printf("Mart, Nisan, Mayýs");
			break;
		case (char)sonbahar:
			printf("Eylül, Ekik, Kasým");
			break;
		default:
			printf("Lütfen Geçerli Mevsim Girin.\n");
			goto don;
			break;
	}
	getch();
}
