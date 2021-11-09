#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

class a
{
	private:
		int degera;
	public:
		int f1(){return degera = 10;}	
};

class b: public a
{
	private:
		int degerb;
	public:
		int f1(){return degerb = 20;}	
};

class c: public a
{
	private:
		int degerc;
	public:
		int f2(){return degerc = 30;}	
};

class d: public b, public c
{
	private:
		int degerd;
	public:
		int f3(){return degerd = 40;}	
}

/*
	Virtual Class:
		Yukardaki sýnýf düzeninde d sýnýfýndan nesne türetildiði zaman ilk önce b sýnýfýndan miras alýndýðý için b sýnýfýna
	sonra ise a sýnýfýna gider ve oluþturur daha sonra c sýnýfýndan miras aldýðý için önce c sýnýfýna sonra a sýnýfýna giderek
	sýnýflarý oluþturur yani d sýnýfýnda 2 adet farklý a nesneleri var olmuþ oluyor bu sorunu nasýl çözeriz ?
*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	b *obj = new b();
	std::cout << "Class A: " << obj->a::f1() << std::endl;
	std::cout << "Class B: " << obj->f1() << std::endl;
	delete obj;
	return 0;
}
