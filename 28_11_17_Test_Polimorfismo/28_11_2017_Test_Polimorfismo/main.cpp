//2017_11_28
//Primi esempi del polimorfismo
#include <stdio.h>
#include <stdlib.h>
#include "Figura.h"
#include "Cerchio.h"
#include "Rettangolo.h"



void main (void)
{
	CFigura* forma[10];
	int ne;


	forma[0] = new CCerchio(10);
	forma[1] = new CRettangolo(5,10);
	forma[2] = new CCerchio(20);
	//stampa dell'area delle varie figure 
	ne=3;
	for(int i=0 ; i<ne ; i++)
	{
		printf("Figura: %i %s - Area %f\n",i,forma[i]->GetNome(),forma[i]->Area());
	}
	system("pause");
}