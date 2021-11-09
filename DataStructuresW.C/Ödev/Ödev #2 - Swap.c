#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

void swap(int *x, int *y)
{
	int gecici;
	gecici = *x;
	*x = *y;
	*y = gecici;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int a, b;
	printf("Ýki adet sayý giriniz: ");
	scanf("%d %d", &a, &b);
	printf("a: %d ve b: %d", a, b);
	swap(&a, &b);
	printf("\na: %d ve b: %d", a, b);
	getch();
	return 0;
}
