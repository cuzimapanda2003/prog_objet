using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate int CalculDel(int[] t);

       
        static int Calculer( int [] t)
        {
            int somme = 0;
            foreach (var item in t)
            {
                somme += item;

            }
            return somme;

        }
        //static int Returnint(int [] t2)
        //{
        //    return 11;
        //}
        static void Afficherresult(CalculDel sdel ,  int []tab)
        {
            int somme = sdel(tab);
            Console.WriteLine(somme);

        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4 };
            CalculDel sdel= Calculer;
            Afficherresult(sdel, tab);
            Console.ReadKey();
        }
    }
}








