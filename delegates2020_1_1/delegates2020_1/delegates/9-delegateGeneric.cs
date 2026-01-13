using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{// delegues générique
    // le type des paramètre peut varier
    public delegate T plus<T>(T param1, T param2);
    public delegate U plusG<T,U>(T param1, U param2);
    public delegate V plusf<T,U,V> (T param1, U param2);
    // on peut faire des délégués peut importe le type T
    class Program
    {
       // public delegate T plus<T>(T param1, T param2);
     
        public static int somme(int a, int b)
        {           //T         //T      //T
            return a + b;
        }

        public static string concat(string s1, string s2)
        {
            return s1 + s2;
        }


        //  public delegate U plus<T, U>(T param1, U param2);
        public static string merge(int a, string s)
        {             // U            //T      //U
            return a.ToString() + s;
        }
       // public delegate V plusf<T, U, V>(T param1, U param2);
        public static string autremerge(float a ,int b)
        {            //v                 //T     //U     
            return (a + b).ToString();
        }
       

        static void Main(string[] args)
        {
            plus<int> add = somme;
            Console.WriteLine(add(2, 20));

            plus<string> con = concat;
            Console.WriteLine(con("Bonjour ", "BOB"));
            Console.ReadKey();

             int no = 3;
             plusG<int, string> addg=merge;
            Console.WriteLine(   addg(no,"no train :"));
            Console.ReadKey();
        }


    }
}