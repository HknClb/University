#include <iostream>
#include <string>
#include <cstdlib>
//#include <conio.h>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	/*std::string inpwo;
	int i; int karakter = 0; int bosluk = 0; int kelime = 0;
	std::cout << "Cümle Giriniz: ";
	getline(std::cin, inpwo);
	for(i = 0; i < inpwo.size(); i++)
	{
		if(inpwo[i] == ' ')
		{
			if(i > 0)
			{
				kelime++;
				bosluk++;
			}
			else if(i < inpwo.size())
				bosluk++;
		}
		else
			karakter++;
	}
	std::cout << "Karakter: " << karakter << "\nBoþluk: " << bosluk << "\nKelime: " << ++kelime;*/
	char ch;
	int kelime = 0; int bosluk = 0; int karakter = 0;
	std::cout << "Cümle giriniz: ";
	while(ch != '\r')
	{
		ch = std::cin.get();
		if(ch == ' ')
		{
			bosluk++;
			kelime++;
		}
		else
			karakter++;
	}
	std::cout << "\nKarakter: " << --karakter << "\nBoþluk: " << bosluk << "\nKelime: " << ++kelime;
	return 0;
}
