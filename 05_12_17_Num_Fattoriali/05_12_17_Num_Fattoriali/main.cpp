// 2017-12-05
// Calcolo numeri Fattoriali tramite struttua Albero Di Ricerca 

//Librerie
#include <stdio.h>
#include <stdlib.h>

//Prototipi 
int Fattoriale(int x);
int FattorialeIte(int x);


//Main 
void main (void)
{
	int n;
	int f;
	printf ("Dammi un numero: \n");
	scanf ("%i",&n);

	//Ricorsiva 
	f = Fattoriale(n);
	printf ("Il fattoriale: %i! e' = %i \n",n,f);

	//Iterativa 
	f = FattorialeIte(n);
	printf ("Il fattoriale: %i! e' = %i \n",n,f);


	system ("pause");
}

//Ricorsiva
int Fattoriale(int x)
{
	if (x <= 1)
		return 1;
	return x*Fattoriale(x-1);
}

//Iterativa 
int FattorialeIte(int x)
{
	int f = 1;
	for (int i = x; i>1; i--)
		f = f*i;
	return f;
}
