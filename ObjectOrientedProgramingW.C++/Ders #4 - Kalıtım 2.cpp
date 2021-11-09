#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*Constructor ve Destructor T�retilmi� S�n�flarda Davran���*/

class mainclass
{
	public:
		int a;
		mainclass():a(5){std::cout << "\tTemel s�n�f constructor de�eri: " << a << std::endl;}	
		~mainclass(){std::cout << "\tTemel s�n�f destructor �al��t�." << std::endl;}
};

class derivedclass: public mainclass
{
	public:
		/*
		Consturctor:
			Bu class dan nesne t�retildi�i zaman ilk ba�ta temel s�n�f constructor fonksiyonu daha sonra bu class�n
			constructor fonksiyonu �al���r.
				Temel->T�retilmi�
		Destructor:
			Bu class dan t�retilmi� nesne silindi�i zaman ilk ba�ta bu s�n�f�n destructor fonksiyonu daha sonra
		bu class�n constructor fonskiyonu �al���r.
				T�retilmi�->Temel	
		*/
		int b;
		derivedclass():b(8){std::cout << "\tT�retilmi� s�n�f constructor de�eri: " << b << std::endl;}
		~derivedclass(){std::cout << "\tT�retilmi� s�n�f destructor �al��t�." << std::endl;}	
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	std::cout << "Constructor" << std::endl;
	derivedclass *c1 = new derivedclass(); /*T�retilmi� s�n�ftan bir nesne t�retilmi�tir.*/
	std::cout << "Destructor" << std::endl;
	delete c1;
	return 0;
}
