#include <stdio.h>
#include <locale.h>

main () {
	setlocale(LC_ALL, "Turkish");
	/*De�i�kenler
	int --> Tam Say�
	double --> Ondal�kl� Say� Kaplad��� Yer B�y�k
	float --> Ondal�kl� Say� Kaplad��� Yer Daha K���k
	char --> Karakter
	
	/*Karakter Tipi
	%c --> Char ��in Kullan�l�r
	%d --> Short Ve �nt ��in Kullan�l�r
	%ld --> Long ��in Kullan�l�r.
	%u --> ��aretsiz �nt Ve Short ��in Kullan�l�r
	%f --> Double Ve Float ��in Kullan�l�r
	%s --> Char ��in Kullan�l�r (string)
	%lu --> ��aretsiz Long ��in Kullan�l�r
	*/
	
	int a;
	printf("Sa Karde�: "); //Printf(); --> Ekrana De�er Yazd�rma.
	scanf("%d",&a);
	printf("As %d",a);
	getch(); //Konsol ekran�n� bir tu�a basmadan kapatmaz.
}
