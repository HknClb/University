#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
#include <string.h>
#include <locale.h>

main()
{
	setlocale(LC_ALL, "Turkish");
	char a[100];
	int i;
	int sesli = 0;
	int sessiz = 0;
	printf("Metin Girin: ");
	gets(a);
	for(i = 0; i < strlen(a); i++)
	{
		switch(a[i])
		{
			case 'a':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
				
			case 'e':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
				
			case 'ý':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			
			case 'i':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			
			case 'o':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			
			case 'ö':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
		
			case 'u':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
		
			case 'ü':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
				
			case 'A':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
				
			case 'E':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
				
			case 'I':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			
			case 'Ý':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			
			case 'O':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			
			case 'Ö':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
		
			case 'U':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
		
			case 'Ü':
				printf("%c --> Sesli\n", a[i]);
				sesli++;
				break;
			default:
				if(a[i] != 32)
				{
					sessiz++;
					printf("%c --> Sessiz\n", a[i]);
				}
				break;
		}
	}
	printf("Bu Metinde %d Adet Sesli %d Adet Sessiz Harf Bulunuyor.", sesli, sessiz);
	getch();
}
