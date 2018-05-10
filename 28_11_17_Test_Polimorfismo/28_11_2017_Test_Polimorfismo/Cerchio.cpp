#include "Cerchio.h"



CCerchio::CCerchio(float raggio)
{
	r = raggio;
}


CCerchio::~CCerchio(void)
{
}


float CCerchio :: Area()
{
	return (r*r)*3.14;
}

char* CCerchio :: GetNome()
{
	return "Cerchio";
}