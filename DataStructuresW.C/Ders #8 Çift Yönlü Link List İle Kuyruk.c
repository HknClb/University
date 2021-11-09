#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <unistd.h>
#include <locale.h>

typedef enum b
{
	false = 0,
	true = 1
}boolean;

/*Her bir düðüm*/
typedef struct n
{
	struct n *previous;
	int data;
	boolean Have_Data; /*Ýçerisinde veri varmý yokmu kontroler etmemizi saðlayan bool deðiþkeni*/
	struct n *next;
}node;

node *root; /*Kök listenin ilk düðümünü gösterir.*/
node *iter; /*Listenin son elemanýný gösterir.*/

/*Efektif olarak loading ekraný saðlayan foknsiyon*/
void Loading_Screen(char a[])
{
	int i;
	for(i = 0; i < 3; i++)
	{
		system("CLS");
		if(i == 0)
			printf("%s.", a);
		else if(i == 1)
			printf("%s..", a);
		else
			printf("%s...", a);
		sleep(1);
	}
}

/*Düðüm ekleme fonksiyonu*/
void Insert()
{
	int inpdata;
	/*rootun verisi yok ise þu ana kadar hiç eleman eklenmemiþ olur dolayýsý ile ilk eklemeye uygun olan kodlar çalýþýr.*/
	if(root->Have_Data == false)
	{
		printf("\nEklemek istediðiniz deðer: ");
		scanf("%d", &inpdata);
		iter->data = inpdata;
		iter->Have_Data = true;
		printf("%d deðeri düðüme eklendi !\n\n", iter->data);
	}
	else
	{
		printf("\nEklemek istediðiniz deðer: ");
		scanf("%d", &inpdata);
		node *prev = iter;
		iter->next = (node *)malloc(sizeof(node));
		iter = iter->next;
		iter->data = inpdata;
		iter->Have_Data = true;
		iter->next = NULL;
		iter->previous = prev;
		printf("%d deðeri düðüme eklendi !\n\n", iter->data);
	}
}

int Is_Empty()
{
	/*Eðer rootun have_Data deðiþkeni boþ ise hiç veri eklenmemiþ anlamýna gelir.*/
	if(root->Have_Data == false)
		return 1;
	else
		return 0;
}

void Display()
{
	if(Is_Empty() == 0)
	{
		node *controler = root;
		int counter = 1;
		printf("\nLink List\n");
		while(controler != NULL)
		{
			printf("%d. düðümün deðeri = %d\n", counter++, controler->data);
			controler = controler->next;
		}
	}
	else
		printf("Gösterilecek düðüm yok !\n");
	printf("\n");
}

void Delete()
{
	node *controler = root;
	if(root->next == NULL)
	{
		root->Have_Data = false;
	}
	else
	{
		root = root->next;
		root->previous = NULL;
		free(controler);
	}
}

void Search(int wanted)
{
	node *controler = root;
	boolean Is_Found = false;
	int foundnode = 1;
	while(controler != NULL)
	{
		if(controler->data == wanted)
		{
			printf("Aranan veri %d.düðümde\n", foundnode);
			foundnode++;
			Is_Found = true;
			controler = controler->next;
		}
		else
		{
			foundnode++;
			controler = controler->next;
		}
	}
	if(!Is_Found)
		printf("Böyle bir veri listede yok !\n");
	printf("\n");
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	root = (node *)malloc(sizeof(node)); /*Root pointerýna bir adet düðüm tutacak yer ayýrma.*/
	iter = root; /*Ýþlemleri iter üzerinden yapacaðýmýz için iteri root a eþitledik.*/	
	int selection; int wanted;
	root->next = NULL;
	root->previous = NULL;
	root->Have_Data = false;
	do
	{
		printf("Listeden yapmak istediðiniz iþlemi seçin\nEkle[1]\nSil[2]\nDüðümleri göster[3]\nAra[4]\nÇýkýþ[5]\n");
		printf("Seçiminiz: ");
		selection = getch() - '0';
		printf("%d\n", selection);
		switch(selection)
		{
			case 1:
				Insert();
				break;
			case 2:
				Delete(root);
				printf("Sýra ilerledi !\n\n");
				break;
			case 3:
				Display();
				break;
			case 4:
				printf("Hangi veriyi aramak istiyorsunuz: ");
				scanf("%d", &wanted);
				Search(wanted);
				break;
			case 5:
				Loading_Screen("Çýkýþ yapýlýyor");
				break;
			default:
				printf("Geçerli bir seçim yapýnýz !\n\n");
				break;
		}
	}while(selection != 5);
	free(root);
	return 0;
}
