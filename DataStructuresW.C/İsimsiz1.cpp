#include <iostream>
#include <cstdlib>
#include <algorithm>
#include <string>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int dizi[] = {11, 22, 33, 44, 55, 66, 77, 88}; int inpval;
	std::cout << "Aranacak deðer: "; std::cin >> inpval;
	int *ptr = std::find(dizi, dizi + 7, inpval);
	std::cout << "Aranan deðer " << (ptr - dizi) << ".indistedir\n" << "[ptr] = " << ptr << "\n[*ptr] = " << *ptr
	<< "\n[&ptr] = " << &ptr << "\n[dizi] = " << dizi << "\n[&dizi] = " << &dizi << std::endl;
	for(int i = 0; i < 8; i++)
		std::cout << "&dizi[" << i << "] = " << &dizi[i] << std::endl;
	return 0;
}
