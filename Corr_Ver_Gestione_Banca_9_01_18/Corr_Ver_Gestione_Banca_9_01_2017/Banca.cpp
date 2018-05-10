#include "Banca.h"
#include <string.h>


CBanca::~CBanca(void)
{
}

//Sviluppo Metodi 
int CBanca :: Scansione()
{
	int n=0;
	for(int i=0;i<MAX_C;i++)
		if(vet[i].ident[0] == 0)
			n++;
	return n;
}


char* CBanca :: Affitta(char* ident,char* data, int n)
{
	int i;
	numeri[0]= 0;
	for(i=0; i<MAX_C;i++)
	{
		if(vet[i].ident[0] == 0)
		{
			sprintf(numeri,"%s %i -",numeri,i);
			strcpy(vet[i].ident,ident);
			strcpy(vet[i].d_aff,data);
			n--;
			if(n == 0)
				break;
		}
	}
	return numeri;
}

char* CBanca :: NumChiavi(int n)
{
	numeri[0]= 0;
	for(int i=0; i<MAX_C;i++)
		if(vet[i].ident[0] == 0){
			sprintf(numeri,"%s %i -",numeri,i);
		}
	return numeri;
}




char* CBanca :: Rilascio(char* ident,int n)
{
	int i; 
	numeri[0]= 0;
	for(int i=0; i<MAX_C;i++)
	{
		if(strcmp(vet[i].ident,ident) == 0 )

	}
	return numeri;
	
}
