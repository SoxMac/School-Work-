#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include "Parc.h"


void main (void)
{
	CParc p;
	int codice,posto;
	char ch;
	do
	{
		system("cls");
		printf("[1] Ingresso\n: ");
		printf("[2] Uscita\n: ");
		printf("[*] Fine\n: ");
		ch = _getch();
		switch(ch)
		{
		case '1':
			p.Entrata(codice, posto);
			if (posto == -1)
				printf ("Parcheggio completo\n");
			else
				printf("Codice : %05i - Posto : %i\n",codice,posto);
			system("pause");
			break;

		case '2':
			printf("Codice? : ");
			scanf("%i",&codice);
			if(p.Uscita(codice,posto) == true)
				printf("Liberato il posto %i\n", posto);
			else
				printf("Codice non valido\n");
			system("pause");
			break;
		}

	}while(ch != '*');

}
