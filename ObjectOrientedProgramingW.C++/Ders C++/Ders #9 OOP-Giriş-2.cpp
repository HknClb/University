#include <iostream>
#include <string>
#include <cstdlib>
#include <locale>

using namespace std;

class kutu
{
	double width;
	double height;
	double size;
	public:
		void set_width(double w);
		void set_height(double h);
		double set_size();
		double get_size()
		{
			return size;
		}
};

void kutu::set_width(double w)
{
	width = w;
}
void kutu::set_height(double h)
{
	height = h;
}

double kutu::set_size()
{
	size = width * height;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	kutu *mybox = new kutu;
	mybox->set_width(100); mybox->set_height(20); mybox->set_size();
	std::cout << "Box size: " << mybox->get_size();
	delete mybox;
	return 0;
}
