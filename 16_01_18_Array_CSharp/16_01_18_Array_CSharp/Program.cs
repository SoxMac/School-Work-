using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16_01_18_Array_CSharp
{
    class Program
    {
        const int MAX = 20;
        static void Main()
        {
            //Dichiarazione dell'array C#
            int[] vet;
            int ne;
            int i;
            //Inserimento dati in array 
            vet = new int[MAX];
            Random rand = new Random(); //Random è una classe
            LeggiNum(out ne);           
            for (i = 0; i < ne; i++)
            {
                vet[i] = rand.Next(100);         
            }
            //Visualizza vettore disordinato 
            Console.WriteLine("Array disordinato: ");
            Visualizza(vet, ne);
            //Ordinamento del vettore
            Console.WriteLine("Array ordinato: ");
            Ordina(vet, ne);
            //Visualizza dopo ordinamento 
            Visualizza(vet, ne);
            Console.ReadKey();
        }//end Main


        //Visualizzazione di un array, Funzione
        static void Visualizza(int[]vet,int ne)
        {
            //Console.Clear();
            for (int i = 0; i < ne; i++)
            {
                Console.WriteLine("V[{0}] = {1}",i,vet[i]);
            }
        }
        //Ordinamento di un array
        static void Ordina(int[] vet, int ne)
        {
            int i,j;
            for (i = 0; i < ne - 1; i++)
            {
                for (j = i + 1; j < ne; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        Scambia(ref vet[i], ref vet[j]);
                    }
                }
            }
        }
        //Scambia due valori
        static void Scambia(ref int x, ref int y)
        {
            int app = x;
            x = y;
            y = app;
        }

        //Lettura di un intero
        static void LeggiNum(out int ne)
        {
            do
            {
                Console.WriteLine("Numero elementi: ");
                ne = Convert.ToInt32(Console.ReadLine());

            } while (ne > MAX);
        }
    }
}
