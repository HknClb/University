#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	int i, son;
	printf("Aralýðý Giriniz: ");
	scanf("%d %d", &i, &son);
	for(i += 1; i < son; i++)
	{
		printf("                                                            %d\n",i);	
	}	
	getch();
}
/*
*/
