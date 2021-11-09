#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*
method tanýmlama yani fonksiyon tanýmlama gibi tanýmlanýr.
bir sisteme üye aldýðýmýzý farz edelim ve 18 yaþ altý alýmamak istiyoruz public olarak tanýmladýðýmýz
deðiþkene direkt olarak deðerler atanabiliyor bunlarý kontrol edebilmek için de method kullanýrýz.
*/

/*-koordinat kabul etmediðimizi varsayarsak*/

class coordinate
{
	private:
		unsigned int x;
		unsigned int y;
	public:
		bool IsOrigin;
		/*constructor ile baþlangýç deðeri atmak
		coordinate(): IsOrigin(false) {
		}*/
		
		coordinate();
		
		/*origin de olma þansý da var ve bunu da set_coordinate sýrasýnda kontrol
		ederiz.
		Deðer atama iþlemlerini bu method üzerinden yapacaðýz ve eðer atama olumsuz ise 0 olumlu
		ise 1 döndereceðiz.*/
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
	/*static sýnýf*/
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
			std::cout << "Koordinat ekleme baþarýlý..." << std::endl;
		else
			std::cout << "Lütfen geçerli koordinat gir!" << std::endl;
	}while(IsSucces != 1);
	mycor.Display_Coordinate();
	std::cout << "Saðlama kordinat x: " << mycor.Get_X() << " y: " << mycor.Get_Y() << std::endl;
	/*Class Arrays
		Yukarýdaki program gibi sýnýflarýmýzdan birden fazla türetmemiz gerekebilir bunun için iki
	adet yol vardýr.
	1->Düz dizi ile: yukardaki program için coordinate mycor2[kordinat sayýsý]; þeklinde tanýmlanýr.
	2->Pointer ile: yukardaki program için coordinate *mycor3 = new coordinate[kordinat sayýsý] 
	þeklinde tanýmlanýr.
	*/
	return 0;
}
