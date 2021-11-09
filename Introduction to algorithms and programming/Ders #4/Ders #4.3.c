#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main()
{
	setlocale(LC_ALL, "Turkish");
	int i;
	for(i = 0; i <= 1000; i++)
	{
		if(i % 2 != 0)
			printf("%d\t%d\n", i, i + 1);
		//getch();
	}
	getch();
}
