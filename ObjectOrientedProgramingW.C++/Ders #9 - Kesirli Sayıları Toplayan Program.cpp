#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

class fraction
{
	private:
		int numerator;
		int denominator;
		bool Is_Indefinite;
	public:
		fraction()
		{numerator = denominator = 0; Is_Indefinite = false;}
		fraction(int inpnumerator, int inpdenominator)
		{Is_Indefinite = (inpdenominator == 0); numerator = inpnumerator; denominator = inpdenominator;}
		void SET_NUMBER(int inpnumerator, int inpdenominator)
		{Is_Indefinite = (inpdenominator == 0); numerator = inpnumerator; denominator = inpdenominator;}
		int GET_NUMERATOR()
		{return numerator;}
		int GET_DENOMINATOR()
		{return denominator;}
		int smallestcommonfloor(int denominator1, int denominator2)
		{
			int flore = 2;
			while(true)
			{
				if(flore % denominator1 == 0 && flore % denominator2 == 0)
					break;
				else
					flore++;
			}
			return flore;
		}
		fraction operator+(fraction *);	
};

fraction fraction::operator+(fraction *f)
{
	fraction total;
	if(this->denominator == f->denominator)
	{
		total.numerator = this->numerator + f->numerator;
		total.denominator = this->denominator;
	}
	else
	{
		int flore = this->smallestcommonfloor(this->denominator, f->denominator);
		total.numerator = (this->numerator * (flore / this->denominator) + (f->numerator * (flore / f->denominator)));
		total.denominator = flore;
	}
	return total;
}

void allert()
{
	std::cout << "Allert !" << std::endl;
}

int ConvertToInt(std::string buf, int *numberone, int *numbertwo)
{
	int i; int factor = 1;
	char helper;
	*numberone = *numbertwo = 0;
	for(i = 0; i < buf.length(); i++)
	{
		if(buf[i] == '/')
			break;
	}
	if(i == buf.length())
	{
		std::cout << "Bu sayý kesir ifadesi içermiyor !" << std::endl;
		return 0;
	}
	for(i = buf.length() - 1; buf[i] != '/'; i--)
	{
		if(buf[i] == ' ')
			continue;
		helper = buf[i];
		*numbertwo += (((int)helper - '0') * factor);
		factor *= 10;
	}
	i--;
	factor = 1;
	for(i; i >= 0; i--)
	{
		if(buf[i] == ' ')
			continue;
		helper = buf[i];
		*numberone += (((int)helper - '0') * factor);
		factor *= 10;
	}
	return 0;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int numeratorone; int denominatorone; int numeratortwo; int denominatortwo;
	std::string buf;
	fraction *numberone = new fraction();
	fraction *numbertwo = new fraction();
	fraction *total = new fraction();
	std::cout << "Ýlk sayý(ör.(a/b) formatta): "; getline(std::cin, buf);
	ConvertToInt(buf, &numeratorone, &denominatorone);
	buf.clear();
	std::cout << "Ýkinci sayý(ör.(a/b) formatta): "; getline(std::cin, buf);
	ConvertToInt(buf, &numeratortwo, &denominatortwo);
	numberone->SET_NUMBER(numeratorone, denominatorone); numbertwo->SET_NUMBER(numeratortwo, denominatortwo);
	*total = *numberone + numbertwo;
	std::cout << "\n\n" << std::endl;
	std::cout << "          \t " << total->GET_NUMERATOR() << "\nToplamý = \t-----\n" << "          \t " << total->GET_DENOMINATOR() <<
	std::endl;
	delete numberone; delete numbertwo; delete total;
	return 0;
}
