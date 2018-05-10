#include "Parc.h"


CParc::CParc(void)
{
	for (int i=0;i<NMAX;i++)
		posti[i]=0;
	codice = 1;
}


CParc::~CParc(void)
{
}


void CParc :: Entrata(int &cod,int &pos)
{
	pos = Ricerca(0);
	if ( pos == -1)
		return;
	cod = codice;
	posti[pos] = cod;
	codice=codice + 1;
	if (codice > 99999)
		codice = 1;
}


bool CParc :: Uscita(int cod, int &pos)
{
	int i = Ricerca(cod);
	if (i == -1)
		return false;
	pos = i;
	posti[i]=0;
	return true;
}


//ricerca del posto libero o del codice scontrino
int CParc :: Ricerca(int key)
{
	int i;
	for(i = 0; i < NMAX; i++)
	{
		if(posti [i] == key)
			break;
	}
	if( i == NMAX)
		return -1;
	return i;
}