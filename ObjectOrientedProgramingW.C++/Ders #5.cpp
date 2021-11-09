#include <iostream>
#include <string>
#include <cstdlib>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int x; int y;
	std::cout << "1.sayý giriniz: ";
	std::cin >> x;
	std::cout << "2.sayý giriniz: ";
	std::cin >> y;
	if((x - y) % 2 != 0)
		y++;
	for(; x != y; x++, y--)
		std::cout << x << " - " << y << std::endl;
	std::cout << x << " - " << y << std::endl;
	return 0;
}
