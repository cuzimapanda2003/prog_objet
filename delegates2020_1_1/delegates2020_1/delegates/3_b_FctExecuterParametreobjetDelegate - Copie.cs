using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate void SalutationsDel(string n);

        static void DireBonjour(string nom)
        {
            Console.WriteLine("Bonjour "+ nom);
            Console.WriteLine();
        }
        static void DireSalut(string nom)
        {
            Console.WriteLine("Salut " + nom);
            Console.WriteLine();
        }
        static void Executer(SalutationsDel s, string nom)
        {
            s(nom);
        }
        static void Main(string[] args)
        {
            SalutationsDel sdel = DireBonjour;

           sdel += DireSalut;
           
          //sdel("bob");
            Executer(sdel , "bob");

            Console.ReadKey();
        }
    }
}








