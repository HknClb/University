#include <iostream>
#include <string>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int vize; int final; int ort;
	do
	{
		std::cout << "Vize Ve Final Notlarý: ";
		std::cin >> vize >> final;
		if(vize > 100 && vize < 0 && final < 0 && final > 100)
			std::cout << "Lütfen Geçerli Bir Not Giriniz !" << std::endl;
		else
			ort = (vize % 40) + (final % 60);
		if(ort >= 60)
			std::cout << ort << " Notu ile geçtiniz :)";
		else
			std::cout << ort << " Notu ile kaldýnýz :(";
	}while(vize > 100 && vize < 0 && final < 0 && final > 100);
	return 0;
}
