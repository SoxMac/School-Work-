#include "Bin.h"
#include <memory.h>
#include <string.h>

CBin::CBin(int n)
{
	memset(cifra,0,DIM);
	Converti(n);
}

CBin::CBin(char* sn)
{
	memset(cifra,0,DIM);
	this->ne = strlen(sn);
	for (int i = 0 ; i< ne; i++)
		cifra[i] = sn[ne-i-1] - '0';
}

CBin::~CBin(void)
{
}

//metodi protetti
void CBin::Converti(int n)
{
	//cerco il numero di bit della conversione 
	ne = 0;
	/*int k = 1;
	while ( k < n )
	{
		k = k * 2;
		ne++;
	}*/

	//conversione binaria
	//k = ne-1;
	while (n > 0)
	{
		cifra[ne++] = n % 2;
		n = n/2;
		
	}
}

char* CBin ::Get(void)
{
	for (int i = 0; i<ne; i++)
		s[i] = cifra[ne-i-1]+ '0';
	s[ne] = 0;
	return s;
}


CBin CBin :: operator+(const CBin& x)
{
	int i;
	byte c = 0; //bit Curry (riporto)
	byte somma; 
	CBin app; 
	byte max = ne > x.ne ? ne: x.ne;
	for (i =0 ; i < max; i++)
	{
		somma = cifra[i] + x.cifra[i] + c;
		if ( somma > 1 )
		{
			app.cifra[i] = somma - 2;
			c = 1;
		}else{
			app.cifra[i] = somma ;
			c = 0;
		}
	}
	app.ne = i;
	if ( c > 0 )
	{
		app.cifra[i] = c;
		app.ne++;
	}

	return app;
 
}