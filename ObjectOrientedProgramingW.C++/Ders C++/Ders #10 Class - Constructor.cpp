#include <iostream>
#include <cstdlib>
#include <locale>

/*
https://www.youtube.com/channel/UCZwyNoNMbnG6W_Eub5TxI6A/videos
https://www.youtube.com/watch?v=d_Rm3d70pw0&t=224s
*/

class human
{
	std::string tc;
	int yas;
	public:
		std::string isim;
		std::string soyisim;
		human(); /*Kurucucu fonksiyon*/
		~human(); /*Y�k�c� fonksiyon*/	
};

/*
	Constructor Ve Destructor: Kurucu ve y�k�c� fonksiyon olarak �evrilir s�n�f i�erisinde
s�n�f'a veri giri�i yap�l�rken constructor s�n�f i�erisinden veri okunurken destructor kullan�l�r.
*isimleri s�n�f ismi ile ayn� olmak zorundad�r.
*/

human::human()
{
	std::cout << "Hello ";
}

human::~human()
{
	std::cout << "World !";
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	human *person = new human;
	person->isim = "Hakan";
	person->soyisim = "�ELEB�";
	std::cout << "�sim: " << person->isim << " Soyisim: " << person->soyisim << std::endl;
	delete person;
	return 0;
}
