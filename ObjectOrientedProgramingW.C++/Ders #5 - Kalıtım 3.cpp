#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*
	Bir class birden fazla class dan miras alabilir örneðin çocuk classý hem anneden hem babadan özellik miras
alýr. Bunun tanýmlanmasý:
*/

class mother
{
	public:
		std::string haircolour;
		mother(){std::cout << "\t Anne sýnýfý constructor çalýþtý." << std::endl;}
		~mother(){std::cout << "\t Anne sýnýfý destructor çalýþtý." << std::endl;}
};

class father
{
	public:
		double tall;
		father(){std::cout << "\t Baba sýnýfý constructor çalýþtý." << std::endl;}
		~father(){std::cout << "\t Baba sýnýfý destructor çalýþtý." << std::endl;}
			
};

/*Hem anne hem babadan türetilmiþ çocuk sýnýfý*/
class child: public father, public mother
{
	public:
		child()
		{
			tall = 1.70;
			haircolour = "Kýrmýzý";
			std::cout << "\t Çocuk sýnýfý constructor çalýþtý. Boy: " << tall << " Saç: " << haircolour
			<<  std::endl;
		}
		~child()
		{
			tall = -1;
			haircolour = "NULL";
			std::cout << "\t Çocuk sýnýfý destructor çalýþtý. Boy: " << tall << " Saç: " << haircolour
			<<  std::endl;
		}
};
/*
	Eriþme sýrasý vardýr yani ilk baþa father classýný türetilmiþ olarak yazarsak ilk baþ eriþim father classýna olur
yani bu örnek için:
		child->father - child->mother
*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	std::cout << "Constructor" << std::endl;
	child *c1 = new child();
	std::cout << "Destructor" << std::endl;
	delete c1;
	return 0;
}
