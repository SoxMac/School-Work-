#pragma once
#define NMAX 5
class CParc
{
	int posti[NMAX];
	int codice;

public:
	CParc(void);
	~CParc(void);

	void Entrata(int &cod,int &pos);
	bool Uscita(int cod, int &pos); //bool ritorna TRUE se la sbarra si alza FALSE se no 

private:
	int Ricerca(int key);

};

