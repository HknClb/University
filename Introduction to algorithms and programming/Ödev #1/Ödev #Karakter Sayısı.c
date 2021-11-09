#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>
#include <string.h> //--> String ifadelerle ilgili kütüphane.

main()
{
	setlocale(LC_ALL, "Turkish");
	char wrd[1000];
	int cs = 0;
	int sayac = 0;
	printf("Cümlenizi Giriniz: ");
	gets(wrd);
	while(sayac < strlen(wrd)) //---> strlen(); Bir char dizisinin boyutunu bulur.
	{
		if(wrd[sayac] != 32) //--> Boþluk karakterinin ascii kodu 32.
			cs++;
		sayac++;
	}
	printf("Girdiðiniz Metinde %d Adet Karakter Vardýr", cs);
	getch();
}
