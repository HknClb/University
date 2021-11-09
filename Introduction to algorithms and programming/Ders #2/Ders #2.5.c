#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	int a;
	printf("Sayý Giriniz: ");
	scanf("%d", &a);
	if(a < 0)
		printf("%d Sayýsý Negatiftir.",a);
	else if(a == 0)
		printf("%d Sayýsý 0'a Eþittir.",a);
	else
		printf("%d Sayýsý Pozitiftir.",a);
	getch();
}
