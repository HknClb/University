#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>
#include <conio.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	float a, b, sonuc;
	int gelen;
	printf("2 Sayý Giriniz: ");
	scanf("%f %f", &a, &b);
	gel:
	printf("Toplama[0] \nÇýkarma[1] \nÇarpma[2] \nBölme[3] \nÝþlem Seçin: ");
	scanf("%d", &gelen);
	switch(gelen)
	{
		case 0:
			sonuc = a + b;
		break;
		
		case 1:
			sonuc = a - b;
		break;
		
		case 2:
			sonuc = a * b;
		break;
		
		case 3:
			sonuc = a / b;
		break;
		
		default: 
			printf("Geçerli Deðer Girin.\n");
			goto gel;
		break;
	}
	printf("%3.2f\n",sonuc);
	goto gel;
	getch();
}
