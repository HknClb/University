#include <iostream>
#include <string>
#include <cstdlib> /*c deki stdlib.h kütüphanesinin c++ daki ismi*/
#include <locale>

/*0.indis vize 1.indis final vizefinal deðiþkeni de bunu tutuyor. Ogrenci deðiþkeni ise öðrenciyi tutuyor.*/
int notgiris(int vizefinal, int ogrenci, int **notlar)
{
	int girilen;
	/*Notlarýn vize mi final mi olduðunu kontrol eden switch case yapýsý.*/
	switch(vizefinal)
	{
		case 0:
			do
			{
				if(ogrenci < 5)
				{
					std::cout << (ogrenci + 1) << ".Öðrencinin Vize Notu: ";
					std::cin >> girilen;
					if(girilen > 100 || girilen < 0)
						std::cout << "\n Not 100 sistemde yazýlmalýdýr !" << std::endl;
					else
					{
						notlar[vizefinal][ogrenci] = girilen;
						notgiris(vizefinal, ++ogrenci, notlar);
					}	
				}
				else
				{
						ogrenci = 0;
						notgiris(++vizefinal, ogrenci, notlar);	
				}
			}while(girilen > 100 || girilen < 0);
			break;
		case 1:
			do
			{
				if(ogrenci < 5)
				{
					std::cout << ogrenci + 1 << ".Öðrencinin Final Notu: ";
					std::cin >> girilen;
					if(girilen > 100 || girilen < 0)
						std::cout << "\n Not 100 sistemde yazýlmalýdýr !" << std::endl;
					else
					{
						notlar[vizefinal][ogrenci] = girilen;
						notgiris(vizefinal, ++ogrenci, notlar);
					}
				}	
				else
				{
					ogrenci = 0;
					notgiris(++vizefinal, ogrenci, notlar);
				}
			}while(girilen > 100 || girilen < 0);
			break;
		default:
			return 1;
			break;
	}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	/*v ve f deðiþkenleri 50 den küçük not sayýsýný tutmak için.*/
	int v = 0; int f = 0; int i; int j; int **sinif;
	/*Pointerýn ilk boyutu*/ 
	sinif = (int **)malloc(2 * sizeof(int));
	/*Pointerýn ikinci boyutu*/
	for(i = 0; i < 5; i++)
		sinif[i] = (int *)malloc(sizeof(int));
	/*Vtop_1 50 den küçük notlarýn toplamý vtop_2 büyük notlarýn toplamý ftoplarda ayný þekilde final için.*/
	int vtop_1; int vtop_2; int ftop_1; int ftop_2;
	vtop_1 = vtop_2 = ftop_1 = ftop_2 = 0;
	notgiris(0, 0, sinif);
	/*Notlarý 50den küçük olanlarýn sayýsýný hesaplayýp top1'a atan ve 50den büyük olan notlarý top2 ye atan döngü.*/
	for(i = 0; i < 2; i++)
	{
		for(j = 0; j < 5; j++)
		{
			/*Notlarý vizemi final mi diye kontrol etmemize yarayan switch case yapýsý.*/
			switch(i)
			{
				case 0:
					if(sinif[i][j] < 51)
					{
						vtop_1 += sinif[i][j];
						v++;
					}
					else
					{
						vtop_2 += sinif[i][j];
					}
					break;
				case 1:
					if(sinif[i][j] < 51)
					{
						ftop_1 += sinif[i][j];
						f++;
					}
					else
					{
						ftop_2 += sinif[i][j];
					}
					break;
			}
		}
	}
	system("CLS");
	std::cout << "Sýnýfýn Vize 0 - 50 Ortalamasý: " << (vtop_1 /= v) << std::endl;
	std::cout << "Sýnýfýn Vize 50 - 100 Ortalamasý: " << (vtop_2 /= (5 - v)) << std::endl ;
	std::cout << "Sýnýfýn Final 0 - 50 Ortalamasý: " << (ftop_1 /= f) << std::endl;
	std::cout << "Sýnýfýn Final 50 - 100 Ortalamasý: " << (ftop_2 /= (5 - f)) << std::endl;
	free(sinif);
	system("pause");
	return 0;
}
