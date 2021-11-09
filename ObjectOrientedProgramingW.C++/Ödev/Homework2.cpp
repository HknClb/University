#include <iostream>
#include <string>
#include <conio.h>
#include <cstdlib>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	std::string keybuf = "Bir metin gir: ";
	std::string inpnum;
	int ch;
	std::cout << keybuf;
	do
	{
		ch = getche();
		if(ch >= 48 && ch <= 57)
		{
			keybuf += (char)ch;
			inpnum += (char)ch;
		}
		else
		{
			system("CLS");
			std::cout << keybuf;
		}
	}while(ch != '\r');
	system("CLS");
	std::cout << "Girdiðiniz deðer: " + inpnum << std::endl;
	system("pause");
	return 0;
}
