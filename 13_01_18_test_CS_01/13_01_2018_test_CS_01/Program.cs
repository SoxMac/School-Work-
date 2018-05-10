using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace _13_01_2018_test_CS_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, a, area;
            string s;

            Console.Write("Base: ");
            s = Console.ReadLine();
            b = Convert.ToSingle(s);

            Console.Write("Altezza: ");
            a = Convert.ToSingle(Console.ReadLine());

            area = a * b;
            Console.Write("Il rettangolo di base {0} e altezza {1} ha area {2}",b,a,area);

            //Console.Write("Il rettangolo di base "+ b.ToString());

            //Console.Write("e altezza ");
            //Console.Write(a.ToString());

            //int x;
            //char ch;
            //string s;
            //s = "ciao";
            //s = Console.ReadLine(); //Scanf in C, C++
 
            //Console.WriteLine("Ciao mondo!"); //Printf in C , C++ 
            Console.ReadKey(); //Aspetta che leggi un tasto, utilizzato per system("pause"), simile al _getch() ma più potente 
        }
    }
}
