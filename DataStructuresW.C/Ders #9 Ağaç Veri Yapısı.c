#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*
AÐAÇ VERÝ YAPISI:
	Arama, sýralama, söz dizim, veri sýkýþtýrma, çözümleme(syntax analysis), kod optimizasyonu(code optimization)
ve derleyici gerçekleþtirilimindeki ara süreçler gibi çok çeþitli amaçlar için kullanýlan aðaç veri yapýsý, bilgisayar
bilimlerinde önemli yer tuter.
	Aðaç veri yapýsý, günlük yaþamda da karþýlaþtýðýmýz bir yapýdýr. Bir insanýn/bitkinin soy aðacý, hiyerarþik bir
yönetimdeki iliþkiler aðaç veri yapýsý kullanýlarak kolayca grafiksel olarak tanýmlanabilir.
	Aðaç (tree) veri yapýsý, çizge(graph) veri yapýsýnýn bir alt kümesidir. Bir çizgenin aðaç olabilmesi için her bir
düðüm yalnýzca tek bir atasý olmalýdýr.

						[A]								-Düzey1
		[B]				[C]				[D]				-Düzey2
	[E] 	[F]			[G]		[H]		[I]		[J]		-Düzey3
  [K][L]						[M]						-Düzey4

	Bu aðaç yapýsýnda A atadýr ve çocuklarý B, C ve D dir. Bunlar birbirleri ile kardeþtir. B de bir atadýr ve
çocuklarý E ve F dir ve bunlar kardeþ düðümdür. Ayný kural diðer düðümler için de geçerþidir.

DERECE - Derinlik: Bir aðaç yapýsýnýn derecesi, aðaç yapýsý içerisindeki en fazla çocuðu olan düðümün çocuk sayýsý bu
aðaç yapýsýn derecesidir.	
YAPRAK(LEAF): Çocuðu olmayan bir düðüme denir.

Ýlili Aðaç: En az bir en fazla iki adet düðümü olan çocuðu olan aðaç tipidir.
Lemma(doðrulduðu hemen görülebilen, kolayca kanýtlanabilen teorem, teoremin yumuþatýlmýþ hali):
a-)Ýkili bir aðaðçta n. düzeydeði düðümlerin maksimum düðüm sayýsý n >= 1 için 2^(n - 1) dir.
b-)k derinliðinde olan ikili bir aðaçta düðümlerin maksimum sayýsý k >= 1 için (2^k) - 1 dir.

Tam Dolu(full) Ýkili Aðaç: Her düðümün iki adet düðümü olan eksiksiz düðümlü aðaç yapýsýdýr.
Tam(complate) Ýkili Aðaç: Sol sað þeklinde sýralý olarak düðümleri var ise sað tarafý eksik olsa bile tamdýr.
Tam Olmayan(incomplate) Ýkili Aðaç: Eðer soldan saða eksik sýrasýz bir eleman var ise tam deðildir. 
*/

typedef struct n
{
	struct n *leftchild;
	char data;
	struct n *rightchild;
}node;

node *root;
node *iter;

void Insert()
{
	
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int selection;
	root = NULL;
	iter = root;
	do
	{
		printf("Ekle[1]\nSil[2]\nÇýk[3]\nSeçiminiz: ");
		selection = getch() - '0';
		switch(selection)
		{
			case 1:
				
				break;
			case 2:
				
				break;
			case 3:
				printf("Çýkýlýyor...");
				break;
			default:
				printf("Lütfen Geçerli Bir Seçim Yapýnýz\n\n");
				break;
		}
	}while(selection != 3);
	return 0;
}






