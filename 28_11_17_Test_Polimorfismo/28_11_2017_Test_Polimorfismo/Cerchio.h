#pragma once
#include "figura.h"
class CCerchio : public CFigura
{
	float r;
public:
	CCerchio(float raggio=0);
	~CCerchio(void);

	float Area();
	char* GetNome();
};

