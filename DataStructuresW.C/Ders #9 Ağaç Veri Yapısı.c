#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

/*
A�A� VER� YAPISI:
	Arama, s�ralama, s�z dizim, veri s�k��t�rma, ��z�mleme(syntax analysis), kod optimizasyonu(code optimization)
ve derleyici ger�ekle�tirilimindeki ara s�re�ler gibi �ok �e�itli ama�lar i�in kullan�lan a�a� veri yap�s�, bilgisayar
bilimlerinde �nemli yer tuter.
	A�a� veri yap�s�, g�nl�k ya�amda da kar��la�t���m�z bir yap�d�r. Bir insan�n/bitkinin soy a�ac�, hiyerar�ik bir
y�netimdeki ili�kiler a�a� veri yap�s� kullan�larak kolayca grafiksel olarak tan�mlanabilir.
	A�a� (tree) veri yap�s�, �izge(graph) veri yap�s�n�n bir alt k�mesidir. Bir �izgenin a�a� olabilmesi i�in her bir
d���m yaln�zca tek bir atas� olmal�d�r.

						[A]								-D�zey1
		[B]				[C]				[D]				-D�zey2
	[E] 	[F]			[G]		[H]		[I]		[J]		-D�zey3
  [K][L]						[M]						-D�zey4

	Bu a�a� yap�s�nda A atad�r ve �ocuklar� B, C ve D dir. Bunlar birbirleri ile karde�tir. B de bir atad�r ve
�ocuklar� E ve F dir ve bunlar karde� d���md�r. Ayn� kural di�er d���mler i�in de ge�er�idir.

DERECE - Derinlik: Bir a�a� yap�s�n�n derecesi, a�a� yap�s� i�erisindeki en fazla �ocu�u olan d���m�n �ocuk say�s� bu
a�a� yap�s�n derecesidir.	
YAPRAK(LEAF): �ocu�u olmayan bir d���me denir.

�lili A�a�: En az bir en fazla iki adet d���m� olan �ocu�u olan a�a� tipidir.
Lemma(do�ruldu�u hemen g�r�lebilen, kolayca kan�tlanabilen teorem, teoremin yumu�at�lm�� hali):
a-)�kili bir a�a��ta n. d�zeyde�i d���mlerin maksimum d���m say�s� n >= 1 i�in 2^(n - 1) dir.
b-)k derinli�inde olan ikili bir a�a�ta d���mlerin maksimum say�s� k >= 1 i�in (2^k) - 1 dir.

Tam Dolu(full) �kili A�a�: Her d���m�n iki adet d���m� olan eksiksiz d���ml� a�a� yap�s�d�r.
Tam(complate) �kili A�a�: Sol sa� �eklinde s�ral� olarak d���mleri var ise sa� taraf� eksik olsa bile tamd�r.
Tam Olmayan(incomplate) �kili A�a�: E�er soldan sa�a eksik s�ras�z bir eleman var ise tam de�ildir. 
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
		printf("Ekle[1]\nSil[2]\n��k[3]\nSe�iminiz: ");
		selection = getch() - '0';
		switch(selection)
		{
			case 1:
				
				break;
			case 2:
				
				break;
			case 3:
				printf("��k�l�yor...");
				break;
			default:
				printf("L�tfen Ge�erli Bir Se�im Yap�n�z\n\n");
				break;
		}
	}while(selection != 3);
	return 0;
}






