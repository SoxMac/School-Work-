#pragma once 

//Dichiarazione nodo ABR 

struct SNodo{
	int info;
	SNodo* sx;
	SNodo* dx;

};

//Classe ABR 
class ABR
{
	SNodo* r;
public:
	ABR();
	void Ins(SNodo* n); //Iterativo 
	void VisAnt();
	void VisSim();
	void VisDiff();
protected:
	//Visite 
	void VisAnt(SNodo* r);
	void VisSim(SNodo* r);
	void VisDiff(SNodo* r);
}

//Inserimenti 
void InsRic(SNodo*& r, SNodo* n); //Ricorsivo 

//Salva ABR su file binario 
bool SalvaABR(char* nomef,SNodo* r);
//Ricostruito ABR da file binario 
bool CaricaABR(char* nomef,SNodo*& r); //r prende & perchè passata per Reference 

//Libero la lista 
void Libera(SNodo*& r);