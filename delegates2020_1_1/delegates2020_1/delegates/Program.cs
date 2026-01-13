using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static  int taille = 9;
        public delegate void Affichage(int [] t);
        public  delegate bool Ordredetri (int a,int b);

     static void affiche(int []tab)
    {
        for (int i = 0; i < taille; i++)
        {
                Console.Write(tab[i].ToString()+" ");
            
        }
            Console.WriteLine();
       

    }
    static void executer(int []tab, Affichage aff)
    {
        aff(tab);

    }
    static void permutation( ref int a, ref int  b)
    {
        int temp = a;
        a = b;
        b = temp;

    }

    static bool fct_ascendant(int a, int b)
    {
        return b < a;

    }
    static bool fct_descendant(int a, int b)
    {
        return b > a;

    }
    static void tribulle(int [] tab, Ordredetri o)
    {
        for (int nbpassage = 1; nbpassage < taille; nbpassage++)
        {
            for (int i = 0; i < taille - 1; i++)
            {
                if ( o(tab[i], tab[i + 1]) )
                    permutation(ref tab[i],ref  tab[i + 1]);
            }
        }
        affiche(tab);
    }


    static void Main(string[] args)
        {   

        int [] tab = { 5, 2, 7, 8, 6, 9, 4, 3, 1 };
        // ceci
        affiche(tab);

            // Affichage f = affiche;
            Affichage f = new Affichage(affiche);

        // ou ceci
        f(tab);
        // ou ceci
        executer(tab, f);
        // ou ceci
        executer(tab, affiche);
            // ou ceci


           string  choix;
        do
        {
                Console.WriteLine("1-tri ascendant" );
                Console.WriteLine("2-tri ascendant");
                Console.WriteLine("3- quitter");

                Console.WriteLine("votre choix : ");
                choix=Console.ReadLine();
                //int choix = int.TryParse(choixs, out choix);
              
                switch (choix)
                {
                    case "1":  tribulle( tab, fct_ascendant); break; 
                    case "2":  tribulle( tab, fct_descendant); break; 
                    case "3":  Console.WriteLine("3-Quitter"); break;
                    default: Console.WriteLine("choix invalide"); break;
            }

        } while (choix != "3");




            Console.ReadKey();
    }
    }
   }

