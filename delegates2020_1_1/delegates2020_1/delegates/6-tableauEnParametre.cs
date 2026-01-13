using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{// on peut le placer ici afin qu'il soit connu de tout le namespace
    public delegate int CalculDel(int[] tab);
    class Program
    { 
        static int Calculer(int[] t)
        {
            int somme = 0;
            foreach (var v in t)
            {
                somme = somme + v;
            }
            return somme;
        }
        static void Executer(CalculDel s, int [] tab)
        {
            Console.WriteLine(" la somme est :" + s(tab).ToString());
            Console.WriteLine(" la somme est :" + s?.Invoke(tab).ToString());
            Console.WriteLine($" la somme est { s?.Invoke(tab)}");

        }
        static void Main(string[] args)
        {          

            int[] tab = { 1, 2, 3, 4 };

            CalculDel sdel = Calculer;
            Executer(sdel, tab);

            Console.ReadKey();
        }
    }
}









