#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*C++ pure oop deðildir yani saf oop deðildir.*/

/*
class->sýnýf anlamýna gelir içerisinde sýnýfa ait özel veriler genel veriler örneðin bir köpek ele
alalým her köpeðin 4 adet ayaðý vardýr ayak sayýsý ortaktýr vb.
class tanýmlarken;
class class_ismi
{
	ve özelliklerini yazarken;
	3 adet özelliði vardýr.
	a-public->proje içerisinden her yerden eriþilebilir veriler anlamýna gelir.
	b-protected->sadece miras aldýðý sýnýf üzerinden eriþilebilir.
	c-private->default olarak tanýmlýdýr sadece class içerisinden eriþilebilir.
};
*/

class coordinate
{
	public:
		int x;
		int y;
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	/*sabit sýnýf türetirken*/
	coordinate staticcoordinate;
	staticcoordinate.x = 5;
	staticcoordinate.y = 3;
	std::cout << "f(x) = (x->" << staticcoordinate.x << ", y->" << staticcoordinate.y << ")" <<
	std::endl;
	/*dinamic sýnýf türetirken*/
	coordinate *dinamiccoordinate = new coordinate;
	dinamiccoordinate->x = 6;
	dinamiccoordinate->y = 4;
	std::cout << "f(x) = (x->" << dinamiccoordinate->x << ", y->" << dinamiccoordinate->y << ")";
	delete dinamiccoordinate; /*-> delete etmeyi unutmamalý yoksa memory leak oluþur.*/
	return 0;
}
