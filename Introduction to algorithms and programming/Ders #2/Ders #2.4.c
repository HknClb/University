#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main () 
{
	setlocale(LC_ALL, "Turkish");
	int a;
	printf("Say� Giriniz: ");
	scanf("%d", &a);
	if (a % 2 == 0)
	{
		printf("%d Say�s� �ifttir.",a);
	}
	else
	{
		printf("%d Say�s� Tektir.",a);
	}
	getch();
}
