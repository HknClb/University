/*Klavyeden rastgele girilen sayýlardan çift olanlarý bir listeye atan program*/
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <locale.h>

typedef struct n
{
	int data;
	struct n *next;
};

int insert(struct n *root, struct n *iter)
{
	int inp;
	static int a = 0;
	if(a == 0)
	{
		printf("Veri gir: ");
		scanf("%d", &inp);
		if(inp % 2 == 0)
		{
			iter->data = inp;
			iter->next = NULL;
			printf("%d deðeri eklendi\n", inp);
			a++;	
		}
		return inp;	
	}
	else
	{
		printf("Veri gir: ");
		scanf("%d", &inp);
		if(inp % 2 == 0)
		{
			iter->next = (struct n *)malloc(sizeof(struct n));
			iter = iter->next;
			iter->data = inp;
			iter->next = NULL;
			printf("%d deðeri eklendi\n");
		}
		return inp;
	}
}

void display(struct n *root)
{
	struct n *gecici = root;
	while(gecici != NULL)
	{
		printf("%d - ", gecici->data);
		gecici = gecici->next;	
	}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	struct n *root = (struct n *)malloc(sizeof(struct n));
	struct n *iter;
	iter = root;
	int a = 1;
	while(a != 0)
	{
		a = insert(root, iter);	
	}
	display(root);
	free(root);
	free(iter);
	return 0;
}




