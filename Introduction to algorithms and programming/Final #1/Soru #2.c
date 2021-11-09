#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int year = 50000000;
	int y1117 = 2;
	int y101819 = 15;
	int i;
	printf("2009 = 50000000 Kiþi\n");
	for(i = 10; i <= 19; i++)
	{
		if(i == 12)
			printf("20%d = %d Kiþi\n", i, year);
		else if(i >= 11 && i <= 17)
		{
			year =  year + (year * 2 / 100);
			printf("20%d = %d Kiþi\n", i, year);			
		}
		else
		{
			year = year + (year * 15 / 1000);
			printf("20%d = %d Kiþi\n", i, year);
		}
	}
	getch();
}
