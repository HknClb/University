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
		Yukardaki s�n�f d�zeninde d s�n�f�ndan nesne t�retildi�i zaman ilk �nce b s�n�f�ndan miras al�nd��� i�in b s�n�f�na
	sonra ise a s�n�f�na gider ve olu�turur daha sonra c s�n�f�ndan miras ald��� i�in �nce c s�n�f�na sonra a s�n�f�na giderek
	s�n�flar� olu�turur yani d s�n�f�nda 2 adet farkl� a nesneleri var olmu� oluyor bu sorunu nas�l ��zeriz ?
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
