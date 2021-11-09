#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <unistd.h>
#include <locale.h>

typedef struct n
{
	int data;
	struct n *next;	
}node;

struct n *root;
struct n *iter;

void Pop()
{
	static int a = 0; int inp;
	printf("Düðüm verisini gir: ");
	scanf("%d", &inp);
	if(a != 0)
	{
		iter->next = (struct n *)malloc(sizeof(struct n));
		iter = iter->next;
	}
	else
		a++;
	iter->data = inp;
	iter->next = NULL;
}

void Display()
{
	struct n *gecici = root;
	int i = 1;
	while(gecici != NULL)
	{
		printf("%d.Düðüm: [%d][%x]\n", i, gecici->data, gecici);
		gecici = gecici->next;
		i++;
	}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int selection;
	root = (struct n *)malloc(sizeof(struct n));
	iter = root;
	do
	{
		printf("Ekle[1]\nSil[2]\nGöster[3]\nÇýkýþ[4]\nSeçiminiz: ");
		selection = getch() - '0';
		printf("%d\n", selection);
		switch(selection)
		{
			case 1:
				Pop();
				break;
			case 2:
				
				break;
			case 3:
				Display(root);
				break;
			case 4:
				
				break;
			default:
				
				break;
		}
	}while(selection != 4);
	free(iter);
	free(root);
	return 0;
}
