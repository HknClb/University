#include <iostream>
#include <cstdlib>
#include <string>
#include <locale>

/*
	Hava, kara ve su araçlarýný bir sýnýf olarak farz edersek bu sýnýflar da araç sýnýfýndan türetilmiþ miras
almýþtýr. Bir sýnýftan miras alan bir sýnýf oluþturmak için;

ana sýnýf
class A
{
	private:
		tanýmlamalar...
	public:
		tanýmlamalar...
	protected:a
		Sadece bu sýnýftan miras alan sýnýflarýn ulaþabileceði tanýmlamalar...
}

miras alan sýnýf
class B:public-private-protected A
{
	private:
		tanýmlamalar... ->Kendine has özellikler.
	public:
		tanýmlamalar... ->Kendine has özellikler.
	protected:
		Sadece bu sýnýftan miras alan sýnýflarýn eriþebileceði tanýmlamalar... ->Kendinden miras alanlara has özel.
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

/*Buradaki public private yada protectedlar bu vehicle sýnýfýndan miras alana airvehicle sýnýfýn dan türetilen
nesnelerin vehicle ana sýnýfýndaki verilere tanýmlamalara direkt olarak eriþmesi ayarýdýr.*/
class airvehicle:public vehicle
{
	public:
		std::string vehiclename;
		void SET_modelno(std::string inpmodelno)
		{modelno = inpmodelno;}
		std::string GET_modelno()
		{return modelno;}
		/*
			Eðer public vehicle deðilde private vehicle þeklinde tanýmlama yapýlsaydý ve username deðiþkenine
		eriþmek isteseydik bir fonksiyon vasýtasýyla set_username fonksiyonuna eriþmemiz gerekir. 
		*/
};

int main()
{
	setlocale(LC_ALL, "Turkish");
	airvehicle *newairvehicle1 = new airvehicle();
	std::string inpusername; std::string inppassword; std::string inpmodelno;
	std::cout << "Kullanýcý Adý: "; getline(std::cin, inpusername);
	std::cout << "Parola: "; getline(std::cin, inppassword);
	std::cout << "Model No: "; std::cin >> inpmodelno;
	/*Burdaki gibi getline alýrken atlamamasý için std::cin.get(); kullanýlýyor ama std::cin >>; iþleminden
	sonra ise kullanýlýr.*/
	std::cout << "Araç Ýsmi: "; std::cin.get(); getline(std::cin, newairvehicle1->vehiclename);
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

