#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*Stack;
	Türkçe'si yýðýt olan stack bir öncelik belirten durumlarda verileri son giren ilk çýkar mantýðýyla çalýþan bir sistemdir.
Diziler, Pointerlar, Link Listler ile kullanýlabilir.
*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	int stclength; int isaretci = -1; int secim = 0;
	printf("Stack'in Boyutu: ");
	scanf("%d", &stclength);
	int stc[stclength];
	do
	{
		printf("Ekle[1]\nSil[2]\nSon Eleman[3]\nÇýkýþ[4]\nSeçiminiz: ");
		scanf("%d", &secim);
		switch(secim)
		{
			case 1:
				printf("%d.Elemaný Giriniz: ", (++isaretci) + 1);
				scanf("%d", &stc[isaretci]);
				break;
			case 2:
				stc[isaretci] = 0;
				isaretci--;
				printf("Son Eleman Silindi !\n");
				break;
			case 3:
				printf("Yýðýtýn Son Elemaný: [%d] - indisi = [%d]\n", stc[isaretci], isaretci);
				break;
		}
	}while(secim != 4);
	return 0;
}
