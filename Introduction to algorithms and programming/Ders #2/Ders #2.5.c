#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	int a;
	printf("Say� Giriniz: ");
	scanf("%d", &a);
	if(a < 0)
		printf("%d Say�s� Negatiftir.",a);
	else if(a == 0)
		printf("%d Say�s� 0'a E�ittir.",a);
	else
		printf("%d Say�s� Pozitiftir.",a);
	getch();
}
