#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

class coordinate
{
	private:
		int x;
		int y;
	public:
		coordinate(){x = y = 0;}
		coordinate(int s_x, int s_y){x = s_x; y = s_y;}
		coordinate operator+(coordinate *);
		coordinate operator+=(coordinate *);
		coordinate operator-(coordinate *);
		coordinate operator-=(coordinate *);
		bool operator<(coordinate *c);
		bool operator<=(coordinate *c);
		bool operator>(coordinate *c);
		bool operator>=(coordinate *c);
		int GET_X(){return x;}
		int GET_Y(){return y;}
};

coordinate coordinate::operator+(coordinate *c)
{
	coordinate thisc;
	this->x += c->x;
	this->y += c->y;
	return *this;
}

coordinate coordinate::operator+=(coordinate *c)
{
	coordinate thisc;
	this->x += c->x;
	this->y += c->y;
	return *this;
}

coordinate coordinate::operator-(coordinate *c)
{
	coordinate thisc;
	this->x -= c->x;
	this->y -= c->y;
	return *this;
}

coordinate coordinate::operator-=(coordinate *c)
{
	coordinate thisc;
	this->x -= c->x;
	this->y -= c->y;
	return *this;
}

bool coordinate::operator<(coordinate *c)
{
	if(c->x < this->x && c->y < this->y)
		return true;
	else
		return false;
}

bool coordinate::operator<=(coordinate *c)
{
	if(c->x <= this->x && c->y <= this->y)
		return true;
	else
		return false;
}

bool coordinate::operator>(coordinate *c)
{
	if(c->x > this->x && c->y > this->y)
		return true;
	else
		return false;
}

bool coordinate::operator>=(coordinate *c)
{
	if(c->x >= this->x && c->y >= this->y)
		return true;
	else
		return false;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	coordinate *c1 = new coordinate(3, 2);
	coordinate *c2 = new coordinate(523, 3);
	std::cout << (*c1 >= c2) << std::endl;
	*c1 += c2;
	std::cout << "x: " << c1->GET_X() << " y: " << c1->GET_Y() << std::endl;
	*c1 -= c2;
	std::cout << "x: " << c1->GET_X() << " y: " << c1->GET_Y() << std::endl;
	delete c1; delete c2;
	return 0;
}
