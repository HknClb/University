#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

typedef struct n
{
	struct n *left;
	char data;
	struct n *right;
}node;

node *root;
node *iter;

void Insert(char inpdata)
{
	
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int selection; char inpdata;
	root = NULL;
	do
	{
		printf("Ekle[1]\nSil[2]\nAra[3]\Göster[4]\nSeçiminiz: ");
		selection = getch() - '0';
		printf("%d", selection);
		switch(selection)
		{
			case 1:
				if(root == NULL)
				{
					root = (node *)malloc(sizeof(node));
					iter = root;
					printf("Eklenecek veri: "); scanf("%c", &inpdata);
					iter->data = inpdata;
					iter->left = iter->right = NULL;
				}
				else
				{
					printf("Eklenecek veri: ");
					Insert(inpdata);
					
				}
				break;
		}
	}while();
	return 0;
}





