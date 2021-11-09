#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main () 
{
	setlocale(LC_ALL, "Turkish");
	int a;
	printf("Sayý Giriniz: ");
	scanf("%d", &a);
	if (a % 2 == 0)
	{
		printf("%d Sayýsý Çifttir.",a);
	}
	else
	{
		printf("%d Sayýsý Tektir.",a);
	}
	getch();
}
