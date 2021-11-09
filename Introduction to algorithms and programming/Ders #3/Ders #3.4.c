#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	int nt;
	do
	{
		printf("Vize Notunuzu Giriniz: ");
		scanf("%d", &nt);	
	}while( (nt < 0) || (nt > 100) );
	printf("Aferin");
	getch();
}

