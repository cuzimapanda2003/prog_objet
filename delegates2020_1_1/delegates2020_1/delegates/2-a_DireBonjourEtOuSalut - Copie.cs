using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {   public delegate void SalutationsDel();
       
         static void DireBonjour()
        { Console.WriteLine("Bonjour");
          Console.WriteLine();
        }
        static void DireSalut()
        {   Console.WriteLine("Salut");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            SalutationsDel sdel = new SalutationsDel(DireBonjour);

           sdel+= DireSalut;
           sdel();

            sdel -= DireBonjour;
            sdel();
           // sdel.Invoke();
            sdel -= DireSalut;
         if (sdel!=null) sdel();

            Console.ReadKey();
        }
    } 
   }



//static void DireSalut()
//{
//    Console.WriteLine("Salut");
//    Console.WriteLine();
//}


//static void executer(int []tab, Affichage aff)
//{
//    aff(tab);

//}




