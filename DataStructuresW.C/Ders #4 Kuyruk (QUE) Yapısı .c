#include <stdio.h>
#include <locale.h>
#define max 5

int Q[max];
int front; int rear;

void insertQ()
{
	int data;
	if(rear == max)
		printf("Kuyruk Dolu !\n");
	else
	{
		printf("Bir de�er giriniz: ");
		scanf("%d", &data);
		Q[rear] = data;
		rear++;
		printf("Veri kuyru�a eklendi !\n");
	}
}

void deleteQ()
{
	int gecici; int i;
	if(rear == 0)
		printf("Kuyruk bo� !");
	else
	{
		Q[front] = '\0';
		for(i = front; i < rear - 1; i++)
		{
			Q[i] = Q[i + 1];
		}
		Q[i] = '\0';
	}
}

void display()
{
	int i;
	if(rear == 0)
		printf("Kuyruk bo� !");
	else
	{
		for(i = front; i < rear; i++)
			printf("\n%d.Kuyruk eleman�: %d", i + 1, Q[i]);
	}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	front = rear = 0;
	int secim;
	do
	{
		printf("Ekle[1]\nSil[2]\nG�ster[3]\n��k��[4]\nSe�iminiz: ");
		scanf("%d", &secim);
		switch(secim)
		{
			case 1:
				insertQ();
				break;
			case 2:
				deleteQ();
				break;
			case 3:
				display();
				break;
			case 4:
				printf("��k�� yap�ld�...");
				sleep(3);
				break;
			default:
				printf("L�tfen ge�erli bir se�im yap�n�z !\n");
				break;
		}
	}while(secim != 4);
	return 0;
}





