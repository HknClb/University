#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void main()
{
	setlocale(LC_ALL, "Turkish");
	char i;
	for(i = 65; i <= 122; i++)
	{
		if(i > 90 && i <= 96)
		{
			
		}
		else
			printf("%c ", i);
	}
	printf("\n");
	for(i = 'a'; i <= 'z'; i++)
	{
		printf("%c ", i);
		if(i == 'c')
			printf("%c ", 231);
	}
	for(i = 'A'; i <= 'Z'; i++)
	{
		printf("%c ", i);
	}
	getch();
}
