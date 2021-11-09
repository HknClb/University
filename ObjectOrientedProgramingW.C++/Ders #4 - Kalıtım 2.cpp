#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*Constructor ve Destructor Türetilmiþ Sýnýflarda Davranýþý*/

class mainclass
{
	public:
		int a;
		mainclass():a(5){std::cout << "\tTemel sýnýf constructor deðeri: " << a << std::endl;}	
		~mainclass(){std::cout << "\tTemel sýnýf destructor çalýþtý." << std::endl;}
};

class derivedclass: public mainclass
{
	public:
		/*
		Consturctor:
			Bu class dan nesne türetildiði zaman ilk baþta temel sýnýf constructor fonksiyonu daha sonra bu classýn
			constructor fonksiyonu çalýþýr.
				Temel->Türetilmiþ
		Destructor:
			Bu class dan türetilmiþ nesne silindiði zaman ilk baþta bu sýnýfýn destructor fonksiyonu daha sonra
		bu classýn constructor fonskiyonu çalýþýr.
				Türetilmiþ->Temel	
		*/
		int b;
		derivedclass():b(8){std::cout << "\tTüretilmiþ sýnýf constructor deðeri: " << b << std::endl;}
		~derivedclass(){std::cout << "\tTüretilmiþ sýnýf destructor çalýþtý." << std::endl;}	
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	std::cout << "Constructor" << std::endl;
	derivedclass *c1 = new derivedclass(); /*Türetilmiþ sýnýftan bir nesne türetilmiþtir.*/
	std::cout << "Destructor" << std::endl;
	delete c1;
	return 0;
}
