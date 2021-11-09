#include <iostream>
#include <string>
#include <cstdlib>
#include <locale>

class human
{
	public:
		std::string name;
		std::string surname;
		bool cinsiyet;
	private:
		std::string tc;
	public:	
		void tc_checker(std::string tc1)
		{
			int i; int tclast;
			char last = tc1[10];
			tclast = (int)last - '0';
			if(tclast % 2 == 0)
				tc = tc1;
			else
				tc = "NULL";
		}
		
		std::string tc_push()
		{
			return tc;
		}
};

/*
	default olarak class private dir.
	class class_name
	{
		*�ZEL VER�LER VE FONKS�YONLAR
		public
		*GENEL VER�LER VE FONKS�YONLAR
		protected
		*KORUMA ALTINDAK� VER�LER VE FONKS�YONLAR
		-ba�ka s�n�flardan korur miras alan veya t�retilmi� s�n�flarda kullan�labilir.
	}
*/

/*D��arda class fonksiyonu �a��rma
class Box
{



*/

class Box
{
	double width;
	double height;
	public:
		void set_width(double w);
		void set_height(double h);
		double get_size(double a, double b);
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	human person_1;
	std::string inptc; std::string cinsiyet;
	int i;
	std::cout << "Ki�i bilgilerini gir: " << std::endl;
	std::cout << "�sim: ";
	std::cin >> person_1.name;
	std::cout << "Soyisim: ";
	std::cin >> person_1.surname;
	std::cout << "TC: ";
	std::cin >> inptc;
	person_1.tc_checker(inptc);
	std::cout << "Cinsiyet: ";
	std::cin >> cinsiyet;
	for(i = 0; i < cinsiyet.length(); i++)
		cinsiyet[i] = toupper(cinsiyet[i]);
	if(cinsiyet == "BAY")
		person_1.cinsiyet = 0;
	else if(cinsiyet == "BAYAN")
		person_1.cinsiyet = 1;
	else
		printf("TANIMSIZ C�NS�YET");
	std::cout << person_1.name << " " << person_1.surname << " - " << person_1.tc_push() << " - " << cinsiyet;
	return 0;
}


