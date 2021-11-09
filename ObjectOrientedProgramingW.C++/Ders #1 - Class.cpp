#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*C++ pure oop de�ildir yani saf oop de�ildir.*/

/*
class->s�n�f anlam�na gelir i�erisinde s�n�fa ait �zel veriler genel veriler �rne�in bir k�pek ele
alal�m her k�pe�in 4 adet aya�� vard�r ayak say�s� ortakt�r vb.
class tan�mlarken;
class class_ismi
{
	ve �zelliklerini yazarken;
	3 adet �zelli�i vard�r.
	a-public->proje i�erisinden her yerden eri�ilebilir veriler anlam�na gelir.
	b-protected->sadece miras ald��� s�n�f �zerinden eri�ilebilir.
	c-private->default olarak tan�ml�d�r sadece class i�erisinden eri�ilebilir.
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
	/*sabit s�n�f t�retirken*/
	coordinate staticcoordinate;
	staticcoordinate.x = 5;
	staticcoordinate.y = 3;
	std::cout << "f(x) = (x->" << staticcoordinate.x << ", y->" << staticcoordinate.y << ")" <<
	std::endl;
	/*dinamic s�n�f t�retirken*/
	coordinate *dinamiccoordinate = new coordinate;
	dinamiccoordinate->x = 6;
	dinamiccoordinate->y = 4;
	std::cout << "f(x) = (x->" << dinamiccoordinate->x << ", y->" << dinamiccoordinate->y << ")";
	delete dinamiccoordinate; /*-> delete etmeyi unutmamal� yoksa memory leak olu�ur.*/
	return 0;
}
