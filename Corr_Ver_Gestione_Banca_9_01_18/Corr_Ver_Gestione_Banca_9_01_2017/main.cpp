#include <stdio.h>
#include <stdlib.h>
#include "Banca.h"

void main (void)
{
	CBanca banca;
	char str[128];
	printf(banca.Affitta("pippo","10/12/2017",3));
	printf("\n");
	printf(banca.Affitta("mario","12/12/2017",1));
	system("pause");
	


}