#include <stdio.h>
#include <stdlib.h>
#include "Bin.h"


void main (void)
{
	CBin x(20);
	CBin y("1001100");
	CBin z;


	printf ("valore bin : %s\n",x.Get());
	printf ("valore num : %s\n",y.Get());
	z = x + y;
	printf ("z : %s\n",z.Get());
	system("pause");
}