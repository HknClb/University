#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*
	Bir class birden fazla class dan miras alabilir �rne�in �ocuk class� hem anneden hem babadan �zellik miras
al�r. Bunun tan�mlanmas�:
*/

class mother
{
	public:
		std::string haircolour;
		mother(){std::cout << "\t Anne s�n�f� constructor �al��t�." << std::endl;}
		~mother(){std::cout << "\t Anne s�n�f� destructor �al��t�." << std::endl;}
};

class father
{
	public:
		double tall;
		father(){std::cout << "\t Baba s�n�f� constructor �al��t�." << std::endl;}
		~father(){std::cout << "\t Baba s�n�f� destructor �al��t�." << std::endl;}
			
};

/*Hem anne hem babadan t�retilmi� �ocuk s�n�f�*/
class child: public father, public mother
{
	public:
		child()
		{
			tall = 1.70;
			haircolour = "K�rm�z�";
			std::cout << "\t �ocuk s�n�f� constructor �al��t�. Boy: " << tall << " Sa�: " << haircolour
			<<  std::endl;
		}
		~child()
		{
			tall = -1;
			haircolour = "NULL";
			std::cout << "\t �ocuk s�n�f� destructor �al��t�. Boy: " << tall << " Sa�: " << haircolour
			<<  std::endl;
		}
};
/*
	Eri�me s�ras� vard�r yani ilk ba�a father class�n� t�retilmi� olarak yazarsak ilk ba� eri�im father class�na olur
yani bu �rnek i�in:
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
