#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>
#include <string.h> //--> String ifadelerle ilgili k�t�phane.

main()
{
	setlocale(LC_ALL, "Turkish");
	char wrd[1000];
	int cs = 0;
	int sayac = 0;
	printf("C�mlenizi Giriniz: ");
	gets(wrd);
	while(sayac < strlen(wrd)) //---> strlen(); Bir char dizisinin boyutunu bulur.
	{
		if(wrd[sayac] != 32) //--> Bo�luk karakterinin ascii kodu 32.
			cs++;
		sayac++;
	}
	printf("Girdi�iniz Metinde %d Adet Karakter Vard�r", cs);
	getch();
}
