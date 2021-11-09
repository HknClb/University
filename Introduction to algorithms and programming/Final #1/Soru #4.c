#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int x;
	gel:
	printf("F(x) Fonksiyonu Ýçin x Deðerini Giriniz: ");
	scanf("%d", &x);
	if(x >= -3 && x < 3)
	{
		printf("F(%d) = %d\n", x, x);
	}
	else if(x == 3)
	{
		printf("F(%d) = y1 = 0, y2 = %d\n", x, x);
	}
	else if(x > 3 && x < 6)
	{
		printf("F(%d) = 0\n", x);
	}
	else if(x == 6)
	{
		printf("F(%d) = y1 = 0, y2 = 3\n", x);
	}
	else if(x > 6 && x <= 9)
	{
		printf("F(%d) = 3\n", x);
	}
	goto gel;
	getch();
}
