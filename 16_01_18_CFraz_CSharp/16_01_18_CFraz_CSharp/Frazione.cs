using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16_01_18_CFraz_CSharp
{
    public class Frazione 
    {
	    int n, d;
	    string s;
        //Costruttore
	    public Frazione(int num = 0, int den = 1)
        {
            n = num;
            d = den;
        }

	    //metodi
	    public string Get()
        {   
	        MinTer();
            s = n.ToString();
	        if ( d > 1)
		        s = s + "/" + d.ToString();
            return s;
        }

        public void Set(int num = 0, int den = 1)
        {
            n = num;
            d = den;
        }

        public static  Frazione operator +(Frazione f, Frazione f2)
        {
            Frazione app = new Frazione();
            app.d = f.d * f2.d;
            app.n = f.n * f2.d + f.n * f2.d;
            return app;
        }

        public static Frazione operator -(Frazione f, Frazione f2)
        {
            Frazione app = new Frazione();
            app.d = f.d * f2.d;
            app.n = f.n * f2.d + f.n * f2.d;
            return app;
        }
        //public Frazione operator*(Frazione f);
        //public Frazione operator/(Frazione f);

	    //metodi protetti che può usare qualunque membro della classe e i suoi discendenti
	    protected int mcd()
        {
	        int nc = n;
	        int dc = d;

	        if (nc < 0)
		        nc = -nc;
	
	        while(nc != dc)
	        {
		        if (nc > dc)
			        nc = nc - dc;
		        else
			        dc = dc - nc;
	        }
	        return nc;
        }

	    protected void MinTer()
        {
	        int dc = mcd();
	        n = n /dc;
	        d = d /dc;
        }

    };

}

