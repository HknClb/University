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
		~human(); /*Yýkýcý fonksiyon*/	
};

/*
	Constructor Ve Destructor: Kurucu ve yýkýcý fonksiyon olarak çevrilir sýnýf içerisinde
sýnýf'a veri giriþi yapýlýrken constructor sýnýf içerisinden veri okunurken destructor kullanýlýr.
*isimleri sýnýf ismi ile ayný olmak zorundadýr.
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
	person->soyisim = "ÇELEBÝ";
	std::cout << "Ýsim: " << person->isim << " Soyisim: " << person->soyisim << std::endl;
	delete person;
	return 0;
}
