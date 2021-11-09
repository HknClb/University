#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main()
{
	setlocale(LC_ALL, "Turkish");
	//Derece / 180 = Radyan / pi = Grad / 200
	float der, rad, grad;
	float pisay = 3.14;
	printf("Derece giriniz: ");
	scanf("%f", &der);
	rad = (der / 180) * pisay;
	grad = (rad / pisay) * 200;
	printf("%f Derecesi Radyan cinsinden: %f, Grad cinsinden: %f\.", der, rad, grad);
	getch();
}
