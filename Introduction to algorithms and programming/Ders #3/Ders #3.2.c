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
	printf("2 Say� Giriniz: ");
	scanf("%f %f", &a, &b);
	gel:
	printf("Toplama[0] \n��karma[1] \n�arpma[2] \nB�lme[3] \n��lem Se�in: ");
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
			printf("Ge�erli De�er Girin.\n");
			goto gel;
		break;
	}
	printf("%3.2f\n",sonuc);
	goto gel;
	getch();
}
