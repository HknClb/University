#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <locale.h>

int main()
{
	//��genin alan� = a kenar� * b kenar� * arada kalan a��n�n sin�s�.
	//Program dili a��y� radyan cinsinden al�r bu y�zden girilen a�� radyana �evrilmek zorundad�r pi say�s� ise math.h
	//k�t�phanesinin eleman� olan M_PI olarak al�n�r ve sin�s de ayn� �ekildedir.
	setlocale(LC_ALL, "Turkish");
	float alan, der, a, b, rad;
	printf("�lk kenar ikinci kenar ve aradaki a��y� giriniz: ");
	scanf("%f %f %f", &a, &b, &der);
	rad = (der / 180) * M_PI;
	alan = a * b * sin(rad);
	printf("��genin alan� = %5.2f", alan);
	getch();
}
