#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main()
{
	setlocale(LC_ALL, "Turkish");
	int i;
	printf("ONDALIK	  SEKÝZLÝK   ONALTILIK");
	printf("\n-------   --------   ---------\n");
	for(i = 1; i <= 15; i++)
	{
		printf("   %d\t     %o\t\t %x", i, i, i);
		printf("\n");
	}
	getch();
}
