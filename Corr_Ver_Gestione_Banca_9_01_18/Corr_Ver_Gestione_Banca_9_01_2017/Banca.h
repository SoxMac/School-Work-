#pragma once
#define MAX_C 5 
#include <stdio.h>
#include <stdlib.h>
#include <memory.h>

//Dichiarazione struttura
struct SCass{
	char ident[40];
	char d_aff[10];
};

//Dichiarazione classe 
class CBanca
{
	SCass vet[MAX_C];
	char numeri[128]; //stringa per la comunicazione 
public:
	CBanca(){memset(vet,0,sizeof(vet));}
	char* Affitta(char* ident,char* data, int n);
	char* NumChiavi(int n);
	char* Rilascio(char* ident,int n);
	~CBanca(void);
protected:
	int Scansione();

};

