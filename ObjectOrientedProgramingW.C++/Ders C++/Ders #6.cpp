#include <iostream>
#include <string>
#include <cstdlib>
#include <locale>
/*getline ile b�t�n sat�r� okutabiliriz.*/
int main()
{
	setlocale(LC_ALL, "Turkish");
	std::string inpwo;
	std::cout << "L�tfen Bir Kelime Girin: ";
	std::cin >> inpwo;
	std::cout << inpwo.size() << "    " << inpwo.length() << std::endl;
	for(int i = 0; i < inpwo.size(); i++)
		std::cout << inpwo[i] << std::endl;
	return 0;
}
