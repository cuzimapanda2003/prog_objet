using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// voir les classes a b et c delegate execute et exception

namespace delegates
{
    class _10_ACtion_Funck
    {// delegues générique
     // le type des paramètre peut varier
        //public delegate T plus<T>(T param1, T param2);
        //Func<T,T>
        //public delegate U plusG<T, U>(T param1, U param2);
        //Func<T,U>
        //public delegate V plusf<T, U, V>(T param1, U param2);
        //Func<T,U,V>
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
            // Func<float, string, int> del1;
            //   del1=autremerge;
            //   string s=del1(12.6f,5);
            //  string s=del1.Invoke(12.6f,5);


            public static string autremerge(float a, int b)
            {            //v                 //T     //U     
                return (a + b).ToString();
            }
            public static int donneint()
            { return 9; }

            public static void DireBonjour()
            {
                Console.WriteLine("bonjour");
                
                
            }
            public static void Calculer(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            public static int nblettres(string s1, string s2)
            { int s= (s1 + s2).Length;
                 Console.WriteLine("ici");
                return s;
            }
            public static void Executer(Action<int, int> calcul,int a,int b)
            {calcul(a,b);

            }
            static void Main(string[] args)
            { //public delegate T plus<T>(T param1, T param2);
              //   plus<int> add = somme;
                Func<int,int,int> add = somme;
               //      <p1,p2, type return>
                Console.WriteLine(add(2, 20));
                //public delegate T plus<T>(T param1, T param2);
                //   plus<string> con = concat;
                Func<string, string, string> con = concat;
                Console.WriteLine(con("Bonjour ", "BOB"));
             

                int no = 3;
                //  public delegate U plus<T, U>(T param1, U param2);
                //  plusG<int, string> addg = merge;
                Func<int, string,string> addg = merge;
               string results= addg(no, "no train :");
                Console.WriteLine(results);
                results=addg?.Invoke(no, "no car : ");
                Console.WriteLine(results);
                Action<int, int> calcul = Calculer;
                calcul(9, 11);
                calcul.Invoke(9,11);    
                Executer(calcul,9,11);
                // ici soit appeler sa propre fonction
                DireBonjour();
                //Soit placer sa fonction dans son propre delegue
                // et lancer son delegue: 2 façons
                Action saluer = DireBonjour;
                saluer();
                saluer.Invoke();
                // soit se faire une fonction Execute 
                // et envoyer quelle fonction exécuter
                Func<int> donnei = donneint;
               
                int nb = donnei();
               // int? nb2 = donnei?.Invoke();// pas de ? a donne i
              // ce n'est pas if donnei!=null mais return null!!!!
                

                Func<string, string, int> aaa;
                aaa = nblettres;
                Console.WriteLine(aaa("allo","bonjour"));
                Console.WriteLine("demander à une autre classe");
                B b= new B();
                Console.ReadKey();
            }


        }

    }
}
