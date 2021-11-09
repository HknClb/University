#include <stdio.h>
#include <locale.h>

main () {
	setlocale(LC_ALL, "Turkish");
	/*Deðiþkenler
	int --> Tam Sayý
	double --> Ondalýklý Sayý Kapladýðý Yer Büyük
	float --> Ondalýklý Sayý Kapladýðý Yer Daha Küçük
	char --> Karakter
	
	/*Karakter Tipi
	%c --> Char Ýçin Kullanýlýr
	%d --> Short Ve Ýnt Ýçin Kullanýlýr
	%ld --> Long Ýçin Kullanýlýr.
	%u --> Ýþaretsiz Ýnt Ve Short Ýçin Kullanýlýr
	%f --> Double Ve Float Ýçin Kullanýlýr
	%s --> Char Ýçin Kullanýlýr (string)
	%lu --> Ýþaretsiz Long Ýçin Kullanýlýr
	*/
	
	int a;
	printf("Sa Kardeþ: "); //Printf(); --> Ekrana Deðer Yazdýrma.
	scanf("%d",&a);
	printf("As %d",a);
	getch(); //Konsol ekranýný bir tuþa basmadan kapatmaz.
}
