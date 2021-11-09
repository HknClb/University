#include <iostream>
#include <cstdlib>
#include <locale>

class Tipler
{
	int sayac;
	int sayac2;
	public:
		int sayi;
		float onsayi;
		char ch;
		std::string metin;
		bool kontrol;
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	Tipler a;
	a.ch = 'H'; a.kontrol = true; a.metin = "Hakan"; a.onsayi = 5.2; a.sayi = 5;
	a.destructor();
	a.constructor();
	std::cout << a.metin;
	a.destructor();
	a.constructor();
	return 0;
}
