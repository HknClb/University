#include <iostream>
#include <string>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int vize; int final; int ort = 0;
	do
	{
		std::cout << "Vize Ve Final Notlarý: ";
		std::cin >> vize >> final;
		if(vize > 100 || vize < 0 || final < 0 || final > 100)
		{
			std::cout << "Lütfen Geçerli Bir Not Giriniz !" << std::endl;
			continue;
		}
		else
			ort = (vize % 40) + (final % 60);
		if(ort < 40)
			std::cout << "Harf Notunuz F";
		else if(ort > 39 && ort < 50)
			std::cout << "Harf Notunuz E";
		else if(ort > 49 && ort < 60)
			std::cout << "Harf Notunuz D";
		else if(ort > 59 && ort < 70)
			std::cout << "Harf Notunuz C";
		else if(ort > 69 && ort < 85)
			std::cout << "Harf Notunuz B";
		else if(ort > 84 && ort < 101)
			std::cout << "Harf Notunuz A";
			
	}while(vize > 100 || vize < 0 || final < 0 || final > 100);
	return 0;
}
