using System;

namespace _13_01_18_cicli_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //ciclo do-while 
            int i;
            int n = Convert.ToInt32(args[0]);
            i = 0;
            do
            {
                Console.WriteLine(rand.Next(69,69));
                i++;
            } while (i < n);

            //ciclo while 
            i = 0;
            while(i < n ) 
            {
                Console.WriteLine(rand.Next(100));
                i++;
            }

            //ciclo for
            for ( i = 0; i < n; i++ )
            {
                Console.WriteLine(rand.Next(100));            
            }
            Console.ReadKey();
        }
    }
}
