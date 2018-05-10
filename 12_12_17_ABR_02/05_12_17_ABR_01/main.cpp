// 2017-12-05 
// ABR Alberi Binari di Ricerca 

#include <stdio.h>
#include <stdlib.h>
#include <memory.h>
#include "Abr.h"


void main (void)
{
	SNodo* r = 0;
	SNodo* n;
	int valori [] = {200,150,300,120,170};
	int ne = sizeof(valori)/sizeof(int);

	for (int i=0; i < ne; i++)
	{
		n = new(SNodo);
		memset(n,0,sizeof(SNodo));
		n->info = valori[i];
		InsRic(r,n);
	}

	printf ("Visita Anticipata\n");
	VisAnt(r);
	printf("\n\n");
	printf ("Visita Simmetrica\n");
	VisSim(r);
	printf("\n\n");
	printf ("Visita Differita\n");
	VisDiff(r);

	//Salva e Ricarica l'albero da file binario 
	SalvaABR("abr.bin",r);
	printf("\n\n");
	r = 0;
	CaricaABR("abr.bin",r);
	printf("\n\n");
	printf("Eliminati\n");
	Libera(r);
	printf("\n\n");
	system("pause");
}
