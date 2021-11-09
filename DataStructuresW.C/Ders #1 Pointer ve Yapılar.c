#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*Struct Nedir ?
	Struct farklý deðiþkenleri listelemek için kullanýlýr denilebilir.
Typedef -> Tip belirleme anlamýna gelir struct oluþtururken tip belirtiyorum diyorsun.
typedef struct yapinin_ismi
{
	degiskenler	
}ozel_isim;

veya

typedef struct yapinin_ismi
{
	
};
1.Örnekteki þekilde kullanýr isek ozel_isim *str; þeklinde deðiþken tanýmlanabilir
2.Örnekteki þekilde kullanýr isek struct yapinin_ismi *str; þeklinde deðiþken tanýmlanabilir.
Eðer struct ý normal deðiþkene verirsek örneðin ks a; a.olarak ulaþýlýr.
Pointer'a verilirse -> þeklinde ulaþýlýr.
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
