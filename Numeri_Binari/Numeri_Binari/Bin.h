#pragma once
#define DIM 32

typedef unsigned char byte;

class CBin
{
	//attributi
	byte cifra[DIM];
	byte ne;
	char s[DIM+1];
public:
	CBin(int n = 0);
	CBin(char* sn);

	~CBin(void);

	char* Get(void);
	CBin operator+(const CBin& x);

protected:
	void  Converti(int n);
};

