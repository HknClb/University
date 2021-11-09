#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

main ()
{
	setlocale(LC_ALL, "Turkish");
	srand(time(NULL));
	int tutulan;
	char rnd1[12];
	int bul = 0;
	int para = 1;
	int bulamadim;
	int l = 0;
	int save;
	int kont = 0;
	int kon1;
	int a = 0;
	int sayac = 0;
	int koa = 0;
	don:
	if(bulamadim >= 10)
	{
		para -= 30;
		printf("\n\n												BENÝ ÇOK ZORLUYORSUN ABÝ BÝRAZ YAVAÞ ÇOK ZEKÝSÝN 30 TL KAZANDIN !\n\n\n");
	}
	printf("Lütfen 1 ile 50 Arasýnda Aklýnýzdan Sayý Tutun: ");
	/*if(kon1 >= 1)
	{
		tutulan = save;
		printf("%d\n",tutulan);
	}*/
	//else
	//{
		scanf("%d", &tutulan);
	//}	
	if(koa == 3)
	{
		printf("Yeter %d Sayýsýný Yazamassýn 1 ile 50 Arasýnda Aklýnýzdan Sayý Tutun Diyorum aq Salaðý\n", tutulan);
		koa = 0;
		goto don;
	}
	//printf("\n");
	if(tutulan <= 50 && tutulan >= 1)
	{
		int j;
		int i;
		for(i = 0; i < 12; i++)
		{
			sayac++;
			kont = 0;
			int rnd = 1 + rand() % 50;
			save = rnd;
			for(j = 0; j < 12; j++)
			{
				if (rnd1[j] == rnd)
				{
					kont = 1;
				}
			}
			if(kont == 1)
			{
				i--;
				sayac--;
			}
			else
			{
				kont = 0;
				printf("%d - ", rnd);
				if(rnd == tutulan)
				{
					bulamadim = 0;
					l = 0;
					printf("%d Sayýsýný %d Defada Buldum ---> %d tl \n", tutulan, sayac, para);
					para++;
					kon1 = -1;
					a = 1;
					break;
				}
				else
				{
					rnd1[i] = rnd;
				}
			}
		}
		if(a == 0)
		{
			if(bulamadim >= 10)
			{
				bulamadim = 0;
				l = 0;
			}
			bulamadim++;
			l++;
			printf("Tuttuðunuz Sayýyý Bulamadým(%d) \n", l);		
		}
		a = 0;
		//printf("Tekrar Denemek Ýstemiyormusun Ýstiyorsan 1'e Ýstemiyorsan 0'ý Tuþla: ");
		//scanf("%d", &bul);
		//if(bul == 1)
		//{
			rnd1[12];
			kon1 ++;
			sayac = 0;
			for(i = 0; i < 12; i++)
			{
				rnd1[i] = -1;
			}
			goto don;
		//}
	}
	else
		koa++;
	 	goto don;
	getch();
}
