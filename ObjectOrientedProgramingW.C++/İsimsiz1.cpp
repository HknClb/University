#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

class test
{
	public:
		int x;
		int y;
		test(){x = y = 0;}
		test(int, int);
		test operator++(int);
};

test::test(int a, int b)
{x = a; y = b;}

test test::operator++(int)
{x++; y++; return *this;}
int main()
{
	setlocale(LC_ALL, "Turkish");
	test *t1 = new test(5, 4);
	std::cout << t1->x << " " << t1->y << std::endl;
	(*t1)++;
	std::cout << t1->x << " " << t1->y << std::endl;
	delete t1;
	return 0;
}
