#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*Stack;
	T�rk�e'si y���t olan stack bir �ncelik belirten durumlarda verileri son giren ilk ��kar mant���yla �al��an bir sistemdir.
Diziler, Pointerlar, Link Listler ile kullan�labilir.
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
		printf("Ekle[1]\nSil[2]\nSon Eleman[3]\n��k��[4]\nSe�iminiz: ");
		scanf("%d", &secim);
		switch(secim)
		{
			case 1:
				printf("%d.Eleman� Giriniz: ", (++isaretci) + 1);
				scanf("%d", &stc[isaretci]);
				break;
			case 2:
				stc[isaretci] = 0;
				isaretci--;
				printf("Son Eleman Silindi !\n");
				break;
			case 3:
				printf("Y���t�n Son Eleman�: [%d] - indisi = [%d]\n", stc[isaretci], isaretci);
				break;
		}
	}while(secim != 4);
	return 0;
}
