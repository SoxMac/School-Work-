using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16_01_18_CFraz_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Frazione f = new Frazione();
	        Frazione f1 = new Frazione(5,2);
	        Frazione f2 = new Frazione(3);
            Frazione f3 = new Frazione(10,4);
	        f = f3;

            Console.WriteLine("f1 = {0}", f1.Get());
            Console.WriteLine("f2 = {0}", f2.Get());
            Console.WriteLine("f3 = {0}", f3.Get());

            f = f1 + f2;
            Console.WriteLine("{0}+{1}= {3}", f1.Get(), f2.Get(), f.Get());

            ///*f1.Set(7,2);*/
            //f = f1-f2;
            //printf("%s-%s= %s\n", f1.Get(), f2.Get(), f.Get());
            //f = f1*f2;
            //printf("%s*%s= %s\n", f1.Get(), f2.Get(), f.Get());
            //f = f1/f2;
            //printf("%s/%s= %s\n", f1.Get(), f2.Get(), f.Get());

            Console.ReadKey();
        }
    }
}
