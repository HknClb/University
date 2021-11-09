#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

void main()
{
	setlocale(LC_ALL, "Turkish");
	int inpint;
	char carp[10];
	printf("Sayý Gir: ");
	scanf("%d", &inpint);
	int i;
	int a = inpint;
	int j = 0;
	for(i = 2; i <= a;)
	{
		if(inpint % i == 0)
		{
			carp[j] = i;
			inpint = inpint / i;
			j++;
		}
		else
			i++;
	}
	printf("%d Sayýsýnýn Çarpanlarý: ", a);
	for(i = 0; i < strlen(carp); i++)
	{
		if(i + 1 == strlen(carp))
			printf("%d", carp[i]);
		else
			printf("%d.", carp[i]);
	}
	getch();
}
