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
		operator+(coordinate *param);
		void SET_X(int inpx){x = inpx;}
		void SET_Y(int inpy){y = inpy;}
		int GET_X(){return x;}
		int GET_Y(){return y;}
}

coordinate::operator+(coordinate *param)
{
	coordinate *crt = new coordinate();
	crt->SET_X(x + param->GET_X());
	crt->GET_Y(y + param->GET_Y());
	return crt;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	coordinate *c1 = new coordinate();
	coordinate *c2 = new coordinate();
	coordinate *c3 = new coordinate();
	c1->SET_X(5); c1->SET_Y(3);
	c2->SET_X(12); c2->SET_Y(-2);
	c3 = c1 + c2;
	std::cout << "Kordinat = (" << c3->GET_X() << ", " << c3->GET_Y() << ")" << std::endl;
	delete c1;	delete c2; delete c3;
	return 0;
}
