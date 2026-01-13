using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {   public delegate void NomType();
       
         static void DireBonjour()
        {
                Console.WriteLine("Bonjour");
                Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            NomType objet= new NomType(DireBonjour);
           
            objet();


            Console.ReadKey();
        }
    }
   }





//static void executer(int []tab, Affichage aff)
//{
//    aff(tab);

//}




