#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

void main()
{
	setlocale(LC_ALL, "Turkish");
	int inpint;
	float top;
	float ort;
	int i = 0;
	do
	{
		printf("%d.Say�y� Giriniz: ", i+1);
		scanf("%d", &inpint);
		if(inpint == -1)
			continue;
		top += inpint;
		i++;
	}while(inpint != -1);
	ort = top / i;
	printf("Say�lar�n Toplam�:%4.0f Aritmetik Ortalamalar�: %3.1f", top, ort);
	getch();
}
