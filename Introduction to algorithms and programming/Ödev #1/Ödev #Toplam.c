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
		printf("Toplanacak Sayýlarý Giriniz: ");
		scanf("%f %f", &a, &b);
		top = a + b;
		printf("%5.2f + %5.2f = %5.2f\n", a, b, top);
		printf("Tekrar Ýþlem Yapmak Ýstiyormusunuz: ");
		
		scanf(" %c", &ch);//-->Karakter alýrken baþta bir boþluk daha sonra %c koyarak sorun çözülebilir.
		
		/*do //-->Do While döngüsü ile \n kalkana kadar tekrar scanf isteyerek çözülür.
		{
			scanf("%c", &ch);
		}while(ch == '\n');*/
		
		//scanf("%c", &ch);//--> C'de karakter okurken bir problem varmýþ otomatik olarak \n olarak deðer alýyormuþ bu yüzden
		//deðer giremiyoruz.
		
	}while(ch == 'e' || ch == 'E');
	
	//--->2.Þekil
	/*gel:
	printf("Toplanacak Sayýlarý Giriniz: ");
	scanf("%f %f", &a, &b);
	top = a + b;
	printf("%5.2f + %5.2f = %5.2f\n", a, b, top);
	printf("Tekrar Ýþlem Yapmak Ýstiyormusunuz: ");
	scanf(" %c", &ch);
	if(ch == 'e' || ch == 'E')
		goto gel;
	*/
	getch();
}
