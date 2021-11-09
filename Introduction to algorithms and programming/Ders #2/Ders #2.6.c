#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	int a;
	gel:
	printf("Sayý Girin: ");
	scanf("%d", &a);
	if(a % 2 == 0 && a % 3 == 0) 
			printf("%d Sayýsý 2 Ve 3'e Bölünüyor.", a);
	else
		printf("%d Sayýsý 2 Ve 3'e Bölünemiyor.", a);
	printf("\n");
	goto gel;
	getch();
}
