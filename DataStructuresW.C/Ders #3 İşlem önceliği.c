#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*
	Bilgisayarda a + b i�lemi hayat�m�zdaki gibi i�leme sokmaz burda a ve b: operand + ise operat�rd�r. a + b i�lemini �rnek
g�sterelim:
	
	   				   YI�IN	�IKTI
a->��kt�ya gider		[]
-------------------------------->ab	+
b->��kt�ya gider		[]			|
						[]			|
						[]			|
+ -> y���na gider		[+] -> daha sonra ��kt�ya gider.

						�NCEL�K OPERAT�R TABLOSU
									|
Simge		Y���n i�indeki �ncelik de�eri		Y���na gelirken �ncelik de�eri
)						-										-
^(**)					3										4
*,/						2										2
+,-						1										1
(						0										4

Not: ')' operat�r�n h�km� yoktur yani �nceli�i yoktur. E�er '(' ile kar��la��rsa birbirlerini yok ederler.
	
	E�er abcd*-*e/ �eklinde verilen i�lem varsa bunun i�in;
abcd->yi y���na soldan ba�layarak atar�z. Daha sonra ise; (a = 2, b = 25, c = 3, d= 5, e = 4)
[d]
[c]
[b]
[a]
daha sonra ise * operat�r�n� �sten 2 si ile i�leme sokar�z ve onlar� siler sonucu yazar�z yani;
d = 5 ile c = 3 �arp�l�r y���na eklenir. Bu i�lem yap�l�rken ilk �nce �steki sa�a sonra operat�r sonra ise di�er operand
->3 * 5 �eklinde i�lem yap�l�r. Sonras�nda gelen operat�r ise - dir. Y���t �u durumda ise;
[15]
[25]
[2]
bu y�zden 25 - 15 den sonu� 10 olur 25 ve 15 y���ttan ��kar sonu� girer. Daha sonra * geliyor ve 2 * 10 = 20 olmu� oluyor.
Y���tta tek eleman 20 vard�r daha sonra e operand'� ekleniyor ve b�lme yap�l�yor 20 / 4 ten sonu� 5 olarak ��kar.
*/

int main()
{
	setlocale(LC_ALL, "Turkish");
	
	return 0;
}
