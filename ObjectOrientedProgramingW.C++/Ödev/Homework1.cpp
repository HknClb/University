#include <iostream>
#include <string>
#include <cstdlib> /*c deki stdlib.h k�t�phanesinin c++ daki ismi*/
#include <locale>

/*0.indis vize 1.indis final vizefinal de�i�keni de bunu tutuyor. Ogrenci de�i�keni ise ��renciyi tutuyor.*/
int notgiris(int vizefinal, int ogrenci, int **notlar)
{
	int girilen;
	/*Notlar�n vize mi final mi oldu�unu kontrol eden switch case yap�s�.*/
	switch(vizefinal)
	{
		case 0:
			do
			{
				if(ogrenci < 5)
				{
					std::cout << (ogrenci + 1) << ".��rencinin Vize Notu: ";
					std::cin >> girilen;
					if(girilen > 100 || girilen < 0)
						std::cout << "\n Not 100 sistemde yaz�lmal�d�r !" << std::endl;
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
					std::cout << ogrenci + 1 << ".��rencinin Final Notu: ";
					std::cin >> girilen;
					if(girilen > 100 || girilen < 0)
						std::cout << "\n Not 100 sistemde yaz�lmal�d�r !" << std::endl;
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
	/*v ve f de�i�kenleri 50 den k���k not say�s�n� tutmak i�in.*/
	int v = 0; int f = 0; int i; int j; int **sinif;
	/*Pointer�n ilk boyutu*/ 
	sinif = (int **)malloc(2 * sizeof(int));
	/*Pointer�n ikinci boyutu*/
	for(i = 0; i < 5; i++)
		sinif[i] = (int *)malloc(sizeof(int));
	/*Vtop_1 50 den k���k notlar�n toplam� vtop_2 b�y�k notlar�n toplam� ftoplarda ayn� �ekilde final i�in.*/
	int vtop_1; int vtop_2; int ftop_1; int ftop_2;
	vtop_1 = vtop_2 = ftop_1 = ftop_2 = 0;
	notgiris(0, 0, sinif);
	/*Notlar� 50den k���k olanlar�n say�s�n� hesaplay�p top1'a atan ve 50den b�y�k olan notlar� top2 ye atan d�ng�.*/
	for(i = 0; i < 2; i++)
	{
		for(j = 0; j < 5; j++)
		{
			/*Notlar� vizemi final mi diye kontrol etmemize yarayan switch case yap�s�.*/
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
	std::cout << "S�n�f�n Vize 0 - 50 Ortalamas�: " << (vtop_1 /= v) << std::endl;
	std::cout << "S�n�f�n Vize 50 - 100 Ortalamas�: " << (vtop_2 /= (5 - v)) << std::endl ;
	std::cout << "S�n�f�n Final 0 - 50 Ortalamas�: " << (ftop_1 /= f) << std::endl;
	std::cout << "S�n�f�n Final 50 - 100 Ortalamas�: " << (ftop_2 /= (5 - f)) << std::endl;
	free(sinif);
	system("pause");
	return 0;
}
