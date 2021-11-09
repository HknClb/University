/*C++ != PURE OOP*/
#include <iostream> /*Standart Giriþ Çýkýþ Kütüphanesi*/
#include <string> /*String kütüphanesi*/
#include <locale>

using namespace std;
/*Eðer cout veya cin gibi bir fonksiyon kullanýlýrken baþýna hiç bir þey gelmez ise std uzayýna sahip
olduðu anlamýna gelir yani using namespace std; kullanýlmaz ise cout yazarken std::cout; þeklinde 
yazýlýr.*/

int topla(int nmb_1, int nmb_2);

int main()
{
	setlocale(LC_ALL, "Turkish");
	int nmb_1 = 0; int nmb_2 = 0; int toplam;
	toplam = topla(nmb_1, nmb_2);
	cout << "Sayýlarýn Toplamý = " << toplam;
	return 0;
}

int topla(int nmb_1, int nmb_2)
{
	int toplam;
	string fw_1 = "Ýlk Sayý: "; string fw_2 = "Ýkinci Sayý: ";
	cout << fw_1;
	cin >> nmb_1;
	cout << fw_2;
	cin >> nmb_2;
	toplam = nmb_1 + nmb_2;
	return toplam;
}
