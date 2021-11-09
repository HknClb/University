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
		printf("Bir deðer giriniz: ");
		scanf("%d", &data);
		Q[rear] = data;
		rear++;
		printf("Veri kuyruða eklendi !\n");
	}
}

void deleteQ()
{
	int gecici; int i;
	if(rear == 0)
		printf("Kuyruk boþ !");
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
		printf("Kuyruk boþ !");
	else
	{
		for(i = front; i < rear; i++)
			printf("\n%d.Kuyruk elemaný: %d", i + 1, Q[i]);
	}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	front = rear = 0;
	int secim;
	do
	{
		printf("Ekle[1]\nSil[2]\nGöster[3]\nÇýkýþ[4]\nSeçiminiz: ");
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
				printf("Çýkýþ yapýldý...");
				sleep(3);
				break;
			default:
				printf("Lütfen geçerli bir seçim yapýnýz !\n");
				break;
		}
	}while(secim != 4);
	return 0;
}





