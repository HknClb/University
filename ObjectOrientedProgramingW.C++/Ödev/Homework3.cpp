#include <iostream>
#include <string>
#include <cstdlib>
#include <fstream>
#include <cmath>
#include <locale>

void ReadFile(int n, int ***Cor_Arys)
{
	std::ifstream coordinats("numbers.txt");
	std::string coordinat; /*Ge�ici olarak i�erisinde okunan kordinat� tutan de�i�ken*/
	char c; /*Dosyadan karakter karakter okumak i�in de�i�ken*/
	int i; int j; int k; int s; int t; int cor; int a; int add = 1; int counter = 0;
	/*
	i - j - k - s - t: Dizi indisleri i�in de�i�kenler.
	add - a: add de�i�keni a kadar *= ile 10 de�eri al�yor ve string den int a �evirirken birden fazla basamakl� say�lar� alabiliyor.
	cor: i�erisinde �evrilen int de�erini ge�ici olarak tutuyor.
	counter: dosya okuma i�leminin bitmesini kontrol ediyor.
	*/
	/*string den int a �evirirken e�er - varsa �evrilen de�eri negatif yapmay� kontrol ediyor.*/
	bool negative = false;
	k = s = t = a = cor = counter = 0;
	if(coordinats.is_open())
	{
		do
		{
			coordinats.get(c);
			if(c == ',')
			{
				counter++;
				
				/*string to int*/
				for(i = coordinat.length() - 1; i >= 0; i--)
				{
					c = coordinat[i];
					for(j = 0; j < a; j++)
					add *= 10;
					a++;
					cor += ((int)c - '0') * add;
					add = 1;
				}
				
				/*negatif de�erse negatif yap�yor.*/
				if(negative)
					cor *= -1;
				negative = false;
				
				/*�evrilen de�eri dizi i�erisine at�yor.*/
				Cor_Arys[k][s][t] = cor;
				if(t < 2)
					t++;
				else if(s < n - 1)
				{
					t = 0;
					s++;
				}
				else if(k < n - 1)
				{
					t = s = 0;
					k++;
				}
				cor = a = 0;
				coordinat.clear();
			}
			else
			{
				/*- karakter varsa negative i true yap�yor.*/
				if(c == '-')
					negative = true;
				else
					coordinat += c;
			}
		}while(counter < n*n*3);
		/*Dosya kapatma*/
		coordinats.close();
	}
	else
		std::cout << "Dosya Okunamad� !";
}

void Display(int n, int ***Cor_Ary)
{
	int i; int j; int k; int a;
	
	/*Okunan kordinatlar� ekrana yazd�rma*/
	for(i = 0; i < n; i++)
	{
		a = 1;
		std::cout << i + 1 << ".Bulut Kordinatlar�;" << std::endl;
		for(j = 0; j < n; j++)
		{
			std::cout << a << ".Kordinat: ";
			std::cout << "(";
			for(k = 0; k < 3; k++)
			{
				if(k != 2)
					std::cout << Cor_Ary[i][j][k] << ",";
				else
					std::cout << Cor_Ary[i][j][k];		
			}
			std::cout << ")" << std::endl;
			a++;
		}
		std::cout << std::endl;
	}
}

void Points_Distance(int n, int ***Cor_Ary)
{
	int i; int j; int k;
	int distance = 9999999; int a; int Near_Points[2];
	std::cout << "\n\n�ki nokta aras�ndaki uzakl�k..." << std::endl;
	for(i = 0; i < n; i++)
	{
		for(j = 0; j < n; j++)
		{
			for(k = j + 1; k < n; k++)
			{
				a = sqrt(pow(Cor_Ary[i][j][0] - Cor_Ary[i][k][0], 2) + pow(Cor_Ary[i][j][1] - Cor_Ary[i][k][1], 2) +
				pow(Cor_Ary[i][j][2] - Cor_Ary[i][k][2], 2));
				if(distance >= a)
				{
					distance = a;
					Near_Points[0] = j + 1;
					Near_Points[1] = k + 1;
				}
			}
		}
		std::cout << i + 1 << ".Buluttaki En Yak�n �ki Nokta: " << Near_Points[0] << " ve " << Near_Points[1] << " uzakl�klar� = " <<
		distance << " Birim" << std::endl;
		distance = 9999999;
	}
}

void Clouds_Distance(int n, int ***Cor_Ary)
{
	std::cout << "\n\n�ki bulut aras�ndaki uzakl�k..." << std::endl;
	int i; int j; int k; int a; int distance = 9999999; int s = 0; int Near_Clouds[2];
	for(i = 0; i < n; s++)
	{
		for(j = i + 1; j < n; j++)
		{
			for(k = 0; k < n; k++)
			{
				a = sqrt(pow(Cor_Ary[i][s][0] - Cor_Ary[j][k][0], 2) + pow(Cor_Ary[i][s][1] - Cor_Ary[j][k][1], 2) + 
				pow(Cor_Ary[i][s][2] - Cor_Ary[j][k][2], 2));
				if(distance > a)
				{
					distance = a;
					Near_Clouds[0] = i + 1;
					Near_Clouds[1] = j + 1;
				}
			}
		}
		if(s == n - 1)
		{
			i++;
			s = 0;
		}
	}
	std::cout << "En Yak�n �ki Bulut: " << Near_Clouds[0] << " ve " << Near_Clouds[1] << " uzakl�klar� = " <<
	distance << " Birim" << std::endl;
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	int i; int j; int k; int n; int a;
	
	/*n de�erini 1 - 40 olmak �art� ile alan do while d�ng�s�*/
	do
	{
		std::cout << "[1 - 40] De�erlerine kadar olacak �ekilde n gir: ";
		std::cin >> n;
		if(n < 1 || n > 57)
			std::cout << "L�tfen ge�erli bir de�er giriniz !" << std::endl;
	}while(n < 1 || n > 57);
	
	/*3 boyutlu pointer dizisi olu�turma.*/
	int ***Cor_Ary = (int ***)malloc(sizeof(int) * n * n * 3);
	for(i = 0; i < n; i++)
		Cor_Ary[i] = (int **)malloc(sizeof(int) * n * 3);
	for(i = 0; i < n; i++)
	{
		for(j = 0; j < n; j++)
		{
			Cor_Ary[i][j] = (int *)malloc(sizeof(int) * 3);
		}
	}
	
	/*Dosyadaki kordinatlar� okumas� i�in fonksiyon*/
	ReadFile(n, Cor_Ary);
	
	/*Dosyadaki kordinatlar� yazmas� i�in fonksiyon*/
	Display(n, Cor_Ary);
	
	/*En yak�n iki noktay� yazan fonksiyon*/
	Points_Distance(n, Cor_Ary);
	
	/*En yak�n iki bulutu yazan fonksiyon*/
	Clouds_Distance(n, Cor_Ary);
	
	free(**Cor_Ary);
	free(*Cor_Ary);
	free(Cor_Ary);
	return 0;
}
