#include <iostream>
#include <string>
#include <cstdlib>
#include <locale>

int main()
{
	setlocale(LC_ALL, "Turkish");
	int i;
	for(i = 0; i < 10; i++)
	{
		if(i == 3)
			continue;
		std::cout << i << std::endl;
	}
		
	return 0;
}
