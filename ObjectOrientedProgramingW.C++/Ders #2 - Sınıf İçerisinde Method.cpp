#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*
method tan�mlama yani fonksiyon tan�mlama gibi tan�mlan�r.
bir sisteme �ye ald���m�z� farz edelim ve 18 ya� alt� al�mamak istiyoruz public olarak tan�mlad���m�z
de�i�kene direkt olarak de�erler atanabiliyor bunlar� kontrol edebilmek i�in de method kullan�r�z.
*/

/*-koordinat kabul etmedi�imizi varsayarsak*/

class coordinate
{
	private:
		unsigned int x;
		unsigned int y;
	public:
		bool IsOrigin;
		/*constructor ile ba�lang�� de�eri atmak
		coordinate(): IsOrigin(false) {
		}*/
		
		coordinate();
		
		/*origin de olma �ans� da var ve bunu da set_coordinate s�ras�nda kontrol
		ederiz.
		De�er atama i�lemlerini bu method �zerinden yapaca��z ve e�er atama olumsuz ise 0 olumlu
		ise 1 d�nderece�iz.*/
		bool Set_Coordinate(int candidate_x, int candidate_y)
		{
			if(candidate_x == 0 && candidate_y == 0)
			{
				IsOrigin = true;
				x = candidate_x;
				y = candidate_y;
				return true;
			}
			else if(candidate_x < 0 || candidate_y < 0)
				return false;
			else
			{
				x = candidate_x;
				y = candidate_y;
				return true;
			}
		}
		void Display_Coordinate()
		{
			if(IsOrigin == 1)
				std::cout << "Bu nokta origindedir. -> ";
			std::cout << "f(x, y) = (x->" << x << ", y->" << y << ")" << std::endl;
		}
		unsigned int Get_X()
		{return x;}
		unsigned int Get_Y()
		{return y;}	
};

coordinate::coordinate()::IsOrigin(0);

int main()
{
	setlocale(LC_ALL, "Turkish");
	/*static s�n�f*/
	coordinate mycor;
//	mycor.IsOrigin = false;
	int x; int y; bool IsSucces = false;
	do
	{
		std::cout << "X: ";
		std::cin >> x;
		std::cout << "Y: ";
		std::cin >> y;
		IsSucces = mycor.Set_Coordinate(x, y);
		if(IsSucces != 0)
			std::cout << "Koordinat ekleme ba�ar�l�..." << std::endl;
		else
			std::cout << "L�tfen ge�erli koordinat gir!" << std::endl;
	}while(IsSucces != 1);
	mycor.Display_Coordinate();
	std::cout << "Sa�lama kordinat x: " << mycor.Get_X() << " y: " << mycor.Get_Y() << std::endl;
	/*Class Arrays
		Yukar�daki program gibi s�n�flar�m�zdan birden fazla t�retmemiz gerekebilir bunun i�in iki
	adet yol vard�r.
	1->D�z dizi ile: yukardaki program i�in coordinate mycor2[kordinat say�s�]; �eklinde tan�mlan�r.
	2->Pointer ile: yukardaki program i�in coordinate *mycor3 = new coordinate[kordinat say�s�] 
	�eklinde tan�mlan�r.
	*/
	return 0;
}
