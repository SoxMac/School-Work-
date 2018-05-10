//Sviluppo Funzioni

#include "Abr.h"
#include <stdio.h>
#include <stdlib.h>

//prototipi locali 
void SalvaBin(FILE* f,SNodo* r);
bool SalvaABR(char* nomef,SNodo* r);
bool CaricaABR(char* nomef,SNodo*& r);

//Inserimento Itearativo 
void Ins(SNodo*& r, SNodo* n)
{
	if ( r == 0 )
		r = n;
	else
	{
		SNodo* prec = r;
		SNodo* cor = r;
		while(cor != 0)
		{
			prec = cor;
			if ( n->info > cor->info )
				cor = cor->dx;
			else
				cor = cor->sx;
		}
		if ( n->info > prec->info )
			prec->dx = n;
		else
			prec->sx = n;
	}
}

//Inserimento Ricorsivo 
void InsRic(SNodo*& r, SNodo* n)
{
	if (r == 0)
		r = n;
	else
		if( n->info > r->info )
			InsRic(r->dx,n);
		else
			InsRic(r->sx,n);
}

//Visita Anticipata 

void ABR :: VisAnt(SNodo* r)
{
	if ( r != 0 )
	{
		printf ("%i\t", r->info);
		VisAnt (r->sx);
		VisAnt (r->dx);
	}

}
void ABR :: VisAnt()
{
	VisAnt(r);
}

//Visita Simmetrica
void ABR :: VisSim(SNodo* r)
{
	if (r!=0)
	{
		VisSim(r->sx);
		printf("%i\t", r->info);
		VisSim(r->dx);
	}
}

//Visita Differita
void ABR :: VisDiff(SNodo* r)
{
	if (r!=0)
	{
		VisDiff(r->sx);
		VisDiff(r->dx);
		printf("%i\t", r->info);
	}
}

//Salva Binario 
void SalvaBin(FILE* f,SNodo* r)
{
	if ( r != 0 )
	{
		fwrite (&r->info,sizeof(int),1,f);
		SalvaBin (f, r->sx);
		SalvaBin (f, r->dx);
	}

}

//Salva ABR su file binario 
bool SalvaABR(char* nomef,SNodo* r)
{
	FILE* f;
	f = fopen(nomef, "wb");
	if ( f==0 )
		return false;
	SalvaBin(f,r);
	fclose(f);
	return true;
}


//Ricostruito ABR da file binario 
bool CaricaABR(char* nomef,SNodo*& r) //r prende & perchè passata per Reference 
{
	FILE* f;
	int info;
	r = 0;
	f = fopen(nomef, "rb");
	if ( f==0 )
		return false;
	while(fread(&info, sizeof(int),1,f)>0)
	{
		SNodo* n = new SNodo();
		n->info = info;
		n->sx = 0;
		n->dx = 0;
		InsRic(r,n);
	}
	fclose(f);
	return true;
}

//Recupera la memoria 
void Libera(SNodo*& r)
{
	if (r!=0)
	{
		VisDiff(r->sx);
		VisDiff(r->dx);
		printf("%i\t", r->info);
		delete(r);
		r = 0;
	}
}