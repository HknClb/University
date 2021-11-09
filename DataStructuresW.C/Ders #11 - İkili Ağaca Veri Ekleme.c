#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

typedef struct n
{
	struct n *left;
	int data;
	struct n *right;
}node;

node *root;
node *iter;

node *Insert(int data)
{
	iter = root;
	int i;
	for(i; ; )
	{
		if(iter->data <= data)
		{
			if(iter->right == NULL)
			{
				iter->right = (node *)malloc(sizeof(node));
				iter = iter->right;
				iter->data = data;
				iter->right = iter->left = NULL;
				break;
			}
			else
				iter = iter->right;
		}
		else
		{
			if(iter->left == NULL)
			{
				iter->left = (node *)malloc(sizeof(node));
				iter = iter->left;
				iter->data = data;
				iter->right = iter->left = NULL;
				break;
			}
			else
				iter = iter->left;
		}
	}
	return iter;
}

node *Search(int data)
{
	iter = root;
	if(data != root->data)
	{
		for(; ;)
		{
			if(iter != NULL)
			{
				if(iter->data < data)
					iter = iter->right;
				else if(iter->data > data)
					iter = iter->left;
				else
					return iter;	
			}
			else
				return NULL;
		}
	}
	else
		return root;
	
}

node *Delete(node *L)
{
	if(L->right != NULL)
	{
		iter = L->right;
		while(iter->left != NULL)
			iter = iter->left;
		L->right = iter->right;
		L->data = iter->data;
		iter = L->right;
		while(iter->left->left != NULL)
			iter = iter->left;
		iter->left = NULL;
		return L;
	}
	else
	{
		if(iter->left != NULL)
		{
			iter = L->left;
			while(iter->right != NULL)
				iter = iter->right;
			iter->left = L->left;
			iter->right = L->right;
			iter->data = L->data;
			iter = L->left;
			while(iter->right->right != NULL)
				iter = iter->right;
			iter->right = NULL;
			return L;
		}
		else
		{
			iter = root;
			for(; ;)
			{
				if(iter->data < L->data)
				{
					if(iter->right->data == L->data)
					{
						iter->right = NULL;
						return L;
					}
					else
						iter = iter->right;	
				}
				else if(iter->data > L->data)
				{
					if(iter->left->data == L->data)
					{
						iter->left = NULL;
						return L;
					}
					else
						iter = iter->left;
				}	
			}
		}
	}		
}

node InOrder(node *L)
{
	if(L != NULL)
	{
		InOrder(L->left);
		printf("%d-", L->data);
		InOrder(L->right);
	}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int selection; int inpdata;
	root = NULL;
	do
	{
		if(root == NULL)
		{
			root = (node *)malloc(sizeof(node));
			iter = root;
			printf("Kök oluþturulmamýþ !\nKök: "); scanf("%d", &(iter->data));
			iter->right = iter->left = NULL;
		}
		printf("Ekle[1]\nSil[2]\nDolaþ[3]\nÇýkýþ[4]\nSeçiminiz: "); selection = getch() - '0';
		printf("%d\n", selection);
		switch(selection)
		{
			case 1:
				printf("Eklenecek veri: "); scanf("%d", &inpdata);
				iter = Insert(inpdata);
				if(iter != NULL)
					printf("%d Ekleme baþarýlý !\n\n", iter->data);
				else
					printf("Ekleme baþarýsýz !\n\n");
				break;
			case 2:
				printf("Silinecek veri: "); scanf("%d", &inpdata);
				iter = Search(inpdata);
				if(iter == root)
					printf("Kök silinmez !\n\n");
				else if(iter == NULL)
					printf("Aðaç %d verisini barýndýrmýyor !\n\n");
				else
				{
					iter = Delete(iter);
					printf("%d Verisi silindi !\n\n", iter->data);
				}
				break;
			case 3:
				InOrder(root);
				printf("\nDolaþým tamamlandý !\n\n");
				break;
			case 4:
				printf("Çýkýþ yapýldý !");
				break;
			default:
				printf("Lütfen geçerli bir seçim yapýnýz !\n\n");
				break;
		}
	}while(selection != 4);
	free(root);
	return 0;
}
