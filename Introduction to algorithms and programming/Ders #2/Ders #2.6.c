#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	int a;
	gel:
	printf("Say� Girin: ");
	scanf("%d", &a);
	if(a % 2 == 0 && a % 3 == 0) 
			printf("%d Say�s� 2 Ve 3'e B�l�n�yor.", a);
	else
		printf("%d Say�s� 2 Ve 3'e B�l�nemiyor.", a);
	printf("\n");
	goto gel;
	getch();
}
