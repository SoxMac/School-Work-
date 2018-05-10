#include "Rettangolo.h"


CRettangolo::CRettangolo(float base,float alt)
{
	b = base;
	h = alt;
}


CRettangolo::~CRettangolo(void)
{
}


float CRettangolo :: Area()
{
	return b*h;
}


char* CRettangolo :: GetNome()
{
	return "Rettangolo";
}