#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	float a, b, top;
	char ch;
	do
	{
		printf("Toplanacak Say�lar� Giriniz: ");
		scanf("%f %f", &a, &b);
		top = a + b;
		printf("%5.2f + %5.2f = %5.2f\n", a, b, top);
		printf("Tekrar ��lem Yapmak �stiyormusunuz: ");
		
		scanf(" %c", &ch);//-->Karakter al�rken ba�ta bir bo�luk daha sonra %c koyarak sorun ��z�lebilir.
		
		/*do //-->Do While d�ng�s� ile \n kalkana kadar tekrar scanf isteyerek ��z�l�r.
		{
			scanf("%c", &ch);
		}while(ch == '\n');*/
		
		//scanf("%c", &ch);//--> C'de karakter okurken bir problem varm�� otomatik olarak \n olarak de�er al�yormu� bu y�zden
		//de�er giremiyoruz.
		
	}while(ch == 'e' || ch == 'E');
	
	//--->2.�ekil
	/*gel:
	printf("Toplanacak Say�lar� Giriniz: ");
	scanf("%f %f", &a, &b);
	top = a + b;
	printf("%5.2f + %5.2f = %5.2f\n", a, b, top);
	printf("Tekrar ��lem Yapmak �stiyormusunuz: ");
	scanf(" %c", &ch);
	if(ch == 'e' || ch == 'E')
		goto gel;
	*/
	getch();
}
