using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void SalutationsDel();
    class _8_delegate3classes
     
    {
        class A
        {
            public static void DireBonjour()
            {
                Console.WriteLine("Bonjour de A");
                Console.WriteLine();
            }
            public static void DireSalut()
            {
                Console.WriteLine("Salut de A");
                Console.WriteLine();
            }

        }
        class B
        {
            public void DireBonjour()
            {
                Console.WriteLine("Bonjour de B");
                Console.WriteLine();
            }
            public void DireSalut()
            {
                Console.WriteLine("Salut de B");
                Console.WriteLine();
            }

        }
        class C
        {
            public static void  Execute(SalutationsDel s   )
            {
                s?.Invoke();
            }
        }
        


      
        class Program
        {


            static void Main(string[] args)
            {
                // SalutationsDel sdel = new SalutationsDel(A.DireBonjour);
                SalutationsDel sdel = A.DireBonjour; // méthode static class.
                B objB = new B();
                sdel += objB.DireBonjour;
                C.Execute(sdel);

                Console.ReadKey();
            }
        }
    }




}
