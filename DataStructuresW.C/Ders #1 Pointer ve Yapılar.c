#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*Struct Nedir ?
	Struct farkl� de�i�kenleri listelemek i�in kullan�l�r denilebilir.
Typedef -> Tip belirleme anlam�na gelir struct olu�tururken tip belirtiyorum diyorsun.
typedef struct yapinin_ismi
{
	degiskenler	
}ozel_isim;

veya

typedef struct yapinin_ismi
{
	
};
1.�rnekteki �ekilde kullan�r isek ozel_isim *str; �eklinde de�i�ken tan�mlanabilir
2.�rnekteki �ekilde kullan�r isek struct yapinin_ismi *str; �eklinde de�i�ken tan�mlanabilir.
E�er struct � normal de�i�kene verirsek �rne�in ks a; a.olarak ula��l�r.
Pointer'a verilirse -> �eklinde ula��l�r.
*/

typedef struct karmasik_sayi{
	int a;
}ks;

int main()
{
	setlocale(LC_ALL, "Turkish");
	ks *p;
	p = (ks *)malloc(sizeof(ks));
	scanf("%d", &(p->a));
	printf("%d", p->a);
	return 0;
}
