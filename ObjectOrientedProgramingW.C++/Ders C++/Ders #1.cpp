/*C++ != PURE OOP*/
#include <iostream> /*Standart Giri� ��k�� K�t�phanesi*/
#include <string> /*String k�t�phanesi*/
#include <locale>

using namespace std;
/*E�er cout veya cin gibi bir fonksiyon kullan�l�rken ba��na hi� bir �ey gelmez ise std uzay�na sahip
oldu�u anlam�na gelir yani using namespace std; kullan�lmaz ise cout yazarken std::cout; �eklinde 
yaz�l�r.*/

int topla(int nmb_1, int nmb_2);

int main()
{
	setlocale(LC_ALL, "Turkish");
	int nmb_1 = 0; int nmb_2 = 0; int toplam;
	toplam = topla(nmb_1, nmb_2);
	cout << "Say�lar�n Toplam� = " << toplam;
	return 0;
}

int topla(int nmb_1, int nmb_2)
{
	int toplam;
	string fw_1 = "�lk Say�: "; string fw_2 = "�kinci Say�: ";
	cout << fw_1;
	cin >> nmb_1;
	cout << fw_2;
	cin >> nmb_2;
	toplam = nmb_1 + nmb_2;
	return toplam;
}
