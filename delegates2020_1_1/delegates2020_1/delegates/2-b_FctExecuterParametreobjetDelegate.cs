using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate void SalutationsDel();

        static void DireBonjour()
        {
            Console.WriteLine("Bonjour ");
            Console.WriteLine();
        }
        static void DireSalut()
        {
            Console.WriteLine("Salut " );
            Console.WriteLine();
        }
        static void Executer(SalutationsDel sdel )
        {
            sdel();
        }
        static void Main(string[] args)
        {
            //SalutationsDel sdel = new SalutationsDel(DireBonjour);
           
            SalutationsDel sdel = DireBonjour;
            sdel += DireSalut;

            //sdel();

            Executer(sdel);

            Console.ReadKey();
        }
    }
}








