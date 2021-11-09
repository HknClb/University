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
		fraction(){Is_Indefinite = false; numerator = denominator = 0;}
		void SET_NUMERATOR(int inpnumerator){numerator = inpnumerator;}
		void SET_DENOMINATOR(int inpdenominator){Is_Indefinite = (inpdenominator == 0); denominator = inpdenominator;}
		int GET_NUMERATOR(){return numerator;}
		int GET_DENOMINATOR(){return denominator;}
		fraction operator+(fraction *);
};

int ekok(int a, int b)
{
	int ekok = 2;
	while(true)
	{
		if(ekok % a == 0 && ekok % b == 0)
			break;
		else
			ekok++;
	}
	return ekok;
}

fraction fraction::operator+(fraction *f)
{
	fraction total;
	if(Is_Indefinite)
		std::cout << "Belirsiz Ýfade !" << std::endl;
	else
	{
		if(this->denominator == f->denominator)
		{
			total.numerator = this->numerator + f->numerator;
			total.denominator = this->denominator;
		}
		else
		{
			int ekok1 = ekok(this->denominator, f->denominator);
			total.numerator = (this->numerator * (ekok1 / this->denominator)) + (f->numerator * (ekok1 / f->denominator));
			total.denominator = ekok1;
		}
	}
	return total;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	fraction *number1 = new fraction();
	fraction *number2 = new fraction();
	fraction *total = new fraction();
	number1->SET_NUMERATOR(0); number1->SET_DENOMINATOR(2);
	number2->SET_NUMERATOR(4); number2->SET_DENOMINATOR(5);
	*total = *number1 + number2;
	std::cout << "Toplam:\n\t" << total->GET_NUMERATOR() << "\n\t--\n\t" << total->GET_DENOMINATOR() << std::endl; 
	delete number1; delete number2;
	return 0;
}
