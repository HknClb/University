#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main()
{
	setlocale(LC_ALL, "Turkish");
	int i;
	for(i = 100; i >= 50; i--)
	{
		if(i % 3 == 0)
			printf("%d ", i);
	}
	getch();
}
