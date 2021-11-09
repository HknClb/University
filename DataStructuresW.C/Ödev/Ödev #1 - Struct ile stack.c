#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*Stack için kullanýlan liste*/
struct str
{
	int top;
	char stackkarakter[10];
};

/*Fonksiyon ile yýðýtýn boyutunu kontrol ediyor.*/
int isEmpty(struct str *p)
{
	if(p->top == 9)
		return 0;
	else if(p->top < 9)
		return 1;
}

/*Yýðýta veri ekliyor.*/
void push(struct str *p, char tba)
{
	if(isEmpty(p) == 1)
		p->stackkarakter[++(p->top)] = tba;
	else if(isEmpty(p) == 0)
		printf("Yýðýt Dolu !\n");
}

/*Yýðýttan veri siliyor.*/
int pop(struct str *p)
{
	return p->stackkarakter[(p->top)--];
}

void bastir(struct str *p)
{
	printf("Yýðýta Eklenilen Son Eleman = [%c] - Ýndisi = [%d]\n", p->stackkarakter[p->top], p->top);
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	/*Yýðýtý tutacak pointer ptr*/
	struct str *ptr = (struct str *)malloc(sizeof(struct str));
	ptr->top = -1;
	/*Ýþlem seçimini tutan deðiþken choice*/
	int choice;
	/*Eklenecek karakteri tutan deðiþken*/
	char tba;
	while(choice != 4)
	{
		printf("Ekle[1]\nSil[2]\nSon Elemaný[3]\nÇýkýþ[4]\nSeçiminiz: ");
		scanf("%d", &choice);
		switch(choice)
		{
			case 1:
				printf("Eklenecek Karakter: ");
				scanf(" %c", &tba);
				push(ptr, tba);
				printf("\nVeri Baþarýyla Eklendi...");
				break;
			case 2:
				if(ptr->top > -1)
					printf("%c Verisi Yýðýttan Silindi", pop(ptr));
				else
					printf("Yýðýtta Veri Yok !");
				break;
			case 3:
				if(ptr->top > -1)
					bastir(ptr);
				else
					printf("Yýðýtta Veri Yok !");
				break;
			default:
				if(choice != 4)
					printf("Lütfen geçerli bir seçim yapýnýz !");
				break;
		}
		printf("\nPress->[ENTER] For Continue...");
		getch();
		system("CLS");
	}
	return 0;
}
