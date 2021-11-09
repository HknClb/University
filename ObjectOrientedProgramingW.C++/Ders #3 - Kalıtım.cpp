#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*
	Hava, kara ve su ara�lar�n� bir s�n�f olarak farz edersek bu s�n�flar da ara� s�n�f�ndan t�retilmi� miras
alm��t�r. Bir s�n�ftan miras alan bir s�n�f olu�turmak i�in;

ana s�n�f
class A
{
	private:
		tan�mlamalar...
	public:
		tan�mlamalar...
	protected:a
		Sadece bu s�n�ftan miras alan s�n�flar�n ula�abilece�i tan�mlamalar...
}

miras alan s�n�f
class B:public-private-protected A
{
	private:
		tan�mlamalar... ->Kendine has �zellikler.
	public:
		tan�mlamalar... ->Kendine has �zellikler.
	protected:
		Sadece bu s�n�ftan miras alan s�n�flar�n eri�ebilece�i tan�mlamalar... ->Kendinden miras alanlara has �zel.
}
*/

class vehicle
{
	private:
		std::string username;
		std::string password;
	public:
		double price;
		vehicle():price(0){}
		void SET_username(std::string inpusername)
		{username = inpusername;}
		void SET_password(std::string inppassword)
		{password = inppassword;}
		std::string GET_username()
		{return username;}
		std::string GET_password()
		{return password;}
	protected:
		std::string modelno;	
};

/*Buradaki public private yada protectedlar bu vehicle s�n�f�ndan miras alana airvehicle s�n�f�n dan t�retilen
nesnelerin vehicle ana s�n�f�ndaki verilere tan�mlamalara direkt olarak eri�mesi ayar�d�r.*/
class airvehicle:public vehicle
{
	public:
		std::string vehiclename;
		void SET_modelno(std::string inpmodelno)
		{modelno = inpmodelno;}
		std::string GET_modelno()
		{return modelno;}
		/*
			E�er public vehicle de�ilde private vehicle �eklinde tan�mlama yap�lsayd� ve username de�i�kenine
		eri�mek isteseydik bir fonksiyon vas�tas�yla set_username fonksiyonuna eri�memiz gerekir. 
		*/
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	airvehicle *newairvehicle1 = new airvehicle();
	std::string inpusername; std::string inppassword; std::string inpmodelno;
	std::cout << "Kullan�c� Ad�: "; getline(std::cin, inpusername);
	std::cout << "Parola: "; getline(std::cin, inppassword);
	std::cout << "Model No: "; std::cin >> inpmodelno;
	/*Burdaki gibi getline al�rken atlamamas� i�in std::cin.get(); kullan�l�yor ama std::cin >>; i�leminden
	sonra ise kullan�l�r.*/
	std::cout << "Ara� �smi: "; std::cin.get(); getline(std::cin, newairvehicle1->vehiclename);
	std::cout << "Fiyat: "; std::cin >> newairvehicle1->price;
	newairvehicle1->SET_username(inpusername);
	newairvehicle1->SET_password(inppassword);
	newairvehicle1->SET_modelno(inpmodelno);
	std::cout
	<< newairvehicle1->GET_username() << "\n" << newairvehicle1->GET_password() << "\n"
	<< newairvehicle1->GET_modelno() << "\n" << newairvehicle1->vehiclename << "\n" << newairvehicle1->price
	<< std::endl;
	delete newairvehicle1;
	return 0;
}

