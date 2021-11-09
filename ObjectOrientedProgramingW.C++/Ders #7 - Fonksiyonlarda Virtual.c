#include <iostream>
#include <cstdlib>
#include <locale>

class dikdortgen
{
	protected:
		int width;
		int height;
		int size;
	public:
		A(){width = 200; height = 300; size = width * height;}
		void SET_WIDTH(int inpwidth)
		{
			if(inpwidth < 0)
				std::cout << "Geniþlik atama baþarýsýz boyut negatif deðer alamaz !" << std::endl;
			else
				width = inpwidth;
		}
		void SET_HEIGHT(int inpheight)
		{
			if(inpheight < 0)
				std::cout << "Yükseklik atama baþarýsýz boyut negatif deðer alamaz !" << std::endl;
			else
				height = inpheight;
		}
		int GET_WIDTH(){return width;}
		int GET_HEIGHT(){return height;}
		int GET_SIZE(){return size = width * size;}
}

class dortgen: public dikdortgen
{
	protected:
		int width;
		int height;
		int size;
	public:
		dortgen(){width = height = 200; size = width * 2;}
		void SET_SIZE(int inp)
		{
			if(inpwidth < 0)
				printf("Boyut atama baþarýsýz boyut negatif deðer alamaz !\n");
			else
				width = height = inp size;
		}
		int GET_WIDTH(){return width;}
		int GET_HEIGHT(){return height;}
		int GET_SIZE(){return size = width * 2;}
}

int main()
{
	setlocale(LC_ALL, "Turkish");
	
	return 0;
}
