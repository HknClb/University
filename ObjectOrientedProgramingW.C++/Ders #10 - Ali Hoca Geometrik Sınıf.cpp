#include <iostream>
#include <cstdlib>
#include <string>
#include <cmath>
#include <locale>

class nokta
{
	protected:
		float en;
		float boy;
	public:
		nokta(float inpen, float inpboy)
		{en = inpen; boy = inpen;}
		nokta(){}
		float GET_CEVRE()
		{return en + boy;}
		float GET_ALAN()
		{return en * boy;}
};

class cizgi: public nokta
{
	public:
		cizgi(float inpen, float inpboy)
		{en = inpen; boy = inpboy;}
		cizgi(){}
		float GET_CEVRE()
		{return en + boy;}
		float GET_ALAN()
		{return en * boy;}
};

class kare: public cizgi
{
	private:
		int kosesayisi;
	public:
		kare(float inpkenaruzunluk, float inpkosesayisi)
		{en = boy = inpkenaruzunluk; kosesayisi = inpkosesayisi;}
		float GET_CEVRE()
		{return (en + boy) * (kosesayisi / 2);}
		float GET_ALAN()
		{return en * boy;}
};

class ucgen: public cizgi
{
	private:
		float a;
		float b;
		float c;
	public:	
		ucgen(float inpa, float inpb, float inpc)
		{a = inpa; b = inpb; c = inpc;}
		float GET_CEVRE()
		{return a + b + c;}
		float GET_ALAN()
		{
			if(a == b && a == c)
			{
				std::cout << "Eþkenar" << std::endl;
				en = a; boy = b + c;
				float tabanuzunluk = a / 2;
				float h = pow(b, 2) - pow(tabanuzunluk, 2);
				h = sqrt(h);
				return (tabanuzunluk * h);
			}
			else if(a == b && a != c)
			{
				std::cout << "Ýkizkenar a == b ve a != c" << std::endl;
				en = c; boy = a + b;
				float tabanuzunluk = c / 2;
				float h = pow(a, 2) - pow(tabanuzunluk, 2);
				h = sqrt(h);
				return (tabanuzunluk * h);
			}
			else if(a == c && b != c)
			{
				std::cout << "Ýkizkenar a == c ve a ve b != c" << std::endl;
				en = b; boy = a + c;
				float tabanuzunluk = b / 2;
				float h = pow(a, 2) - pow(tabanuzunluk, 2);
				h = sqrt(h);
				return (tabanuzunluk * h);
			}
			else if(b == c && a != b)
			{
				std::cout << "Ýkizkenar b == c ve a != b" << std::endl;
				en = a; boy = b + c;
				float tabanuzunluk = a / 2;
				float h = pow(b, 2) - pow(tabanuzunluk, 2);
				h = sqrt(h);
				return (tabanuzunluk * h);
			}
			else
			{
				std::cout << "Çeþitkenar" << std::endl;
				float s = (a + b + c) / 2;
				return sqrt(s * (s - a) * (s - b) * (s - c));
			}
		}
};

class daire: public cizgi
{
	private:
		float cap;
	public:
		daire(float inpcap)
		{cap = inpcap;}
		float GET_CEVRE()
		{return 2 * M_PI * (cap / 2);}
		float GET_ALAN()
		{return M_PI * pow((cap / 2), 2);}
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	ucgen *u1 = new ucgen(5, 6, 8);
	std::cout << "Üçgenin çevresi: " << u1->GET_CEVRE() << "\nÜçgenin alaný: " << u1->GET_ALAN() << std::endl;
	delete u1;
	daire *d1 = new daire(6);
	std::cout << "Dairenin çevresi: " << d1->GET_CEVRE() << "\nDairenin alaný: " << d1->GET_ALAN() << std::endl;
	delete d1;
	return 0;
}
