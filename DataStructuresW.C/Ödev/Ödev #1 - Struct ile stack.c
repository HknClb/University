#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*Stack i�in kullan�lan liste*/
struct str
{
	int top;
	char stackkarakter[10];
};

/*Fonksiyon ile y���t�n boyutunu kontrol ediyor.*/
int isEmpty(struct str *p)
{
	if(p->top == 9)
		return 0;
	else if(p->top < 9)
		return 1;
}

/*Y���ta veri ekliyor.*/
void push(struct str *p, char tba)
{
	if(isEmpty(p) == 1)
		p->stackkarakter[++(p->top)] = tba;
	else if(isEmpty(p) == 0)
		printf("Y���t Dolu !\n");
}

/*Y���ttan veri siliyor.*/
int pop(struct str *p)
{
	return p->stackkarakter[(p->top)--];
}

void bastir(struct str *p)
{
	printf("Y���ta Eklenilen Son Eleman = [%c] - �ndisi = [%d]\n", p->stackkarakter[p->top], p->top);
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	/*Y���t� tutacak pointer ptr*/
	struct str *ptr = (struct str *)malloc(sizeof(struct str));
	ptr->top = -1;
	/*��lem se�imini tutan de�i�ken choice*/
	int choice;
	/*Eklenecek karakteri tutan de�i�ken*/
	char tba;
	while(choice != 4)
	{
		printf("Ekle[1]\nSil[2]\nSon Eleman�[3]\n��k��[4]\nSe�iminiz: ");
		scanf("%d", &choice);
		switch(choice)
		{
			case 1:
				printf("Eklenecek Karakter: ");
				scanf(" %c", &tba);
				push(ptr, tba);
				printf("\nVeri Ba�ar�yla Eklendi...");
				break;
			case 2:
				if(ptr->top > -1)
					printf("%c Verisi Y���ttan Silindi", pop(ptr));
				else
					printf("Y���tta Veri Yok !");
				break;
			case 3:
				if(ptr->top > -1)
					bastir(ptr);
				else
					printf("Y���tta Veri Yok !");
				break;
			default:
				if(choice != 4)
					printf("L�tfen ge�erli bir se�im yap�n�z !");
				break;
		}
		printf("\nPress->[ENTER] For Continue...");
		getch();
		system("CLS");
	}
	return 0;
}
