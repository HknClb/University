#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	int wrt = 0;
	int add = 1;
	int save;
	int i;
	int stp;
	printf("Ka� Ad�ml�k Fibonacci Serisi Yazd�racaks�n�z: ");
	scanf("%d", &stp);
	for(i = 0; i < stp; i++)
	{
		if(i + 1 == stp)
			printf("%d", wrt);
		else
			printf("%d-", wrt);
		save = wrt;
		wrt += add;
		add = save;
	}
	getch();
}
