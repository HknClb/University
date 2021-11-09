#include <iostream>
#include <string>
#include <cstdlib>
#include <locale>
/*getline ile bütün satýrý okutabiliriz.*/
int main()
{
	setlocale(LC_ALL, "Turkish");
	std::string inpwo;
	std::cout << "Lütfen Bir Kelime Girin: ";
	std::cin >> inpwo;
	std::cout << inpwo.size() << "    " << inpwo.length() << std::endl;
	for(int i = 0; i < inpwo.size(); i++)
		std::cout << inpwo[i] << std::endl;
	return 0;
}
