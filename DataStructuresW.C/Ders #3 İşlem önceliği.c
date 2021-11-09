#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*
	Bilgisayarda a + b iþlemi hayatýmýzdaki gibi iþleme sokmaz burda a ve b: operand + ise operatördür. a + b iþlemini örnek
gösterelim:
	
	   				   YIÐIN	ÇIKTI
a->çýktýya gider		[]
-------------------------------->ab	+
b->çýktýya gider		[]			|
						[]			|
						[]			|
+ -> yýðýna gider		[+] -> daha sonra çýktýya gider.

						ÖNCELÝK OPERATÖR TABLOSU
									|
Simge		Yýðýn içindeki öncelik deðeri		Yýðýna gelirken öncelik deðeri
)						-										-
^(**)					3										4
*,/						2										2
+,-						1										1
(						0										4

Not: ')' operatörün hükmü yoktur yani önceliði yoktur. Eðer '(' ile karþýlaþýrsa birbirlerini yok ederler.
	
	Eðer abcd*-*e/ þeklinde verilen iþlem varsa bunun için;
abcd->yi yýðýna soldan baþlayarak atarýz. Daha sonra ise; (a = 2, b = 25, c = 3, d= 5, e = 4)
[d]
[c]
[b]
[a]
daha sonra ise * operatörünü üsten 2 si ile iþleme sokarýz ve onlarý siler sonucu yazarýz yani;
d = 5 ile c = 3 çarpýlýr yýðýna eklenir. Bu iþlem yapýlýrken ilk önce üsteki saða sonra operatör sonra ise diðer operand
->3 * 5 þeklinde iþlem yapýlýr. Sonrasýnda gelen operatör ise - dir. Yýðýt þu durumda ise;
[15]
[25]
[2]
bu yüzden 25 - 15 den sonuç 10 olur 25 ve 15 yýðýttan çýkar sonuç girer. Daha sonra * geliyor ve 2 * 10 = 20 olmuþ oluyor.
Yýðýtta tek eleman 20 vardýr daha sonra e operand'ý ekleniyor ve bölme yapýlýyor 20 / 4 ten sonuç 5 olarak çýkar.
*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	
	return 0;
}
