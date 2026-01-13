using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class B
    {     
       public B()
        {
            Console.WriteLine("classe B");
            A a = new A();// temporaire le temps du constructeur ici
          C c= new C(); 

          Action<int, int> dcalculer = a.Calculer;
            // demande a c d'exécuter a.Calculer(2,3);
          c.Execute(dcalculer,2,3);


            Func<string, string, int> delnb= a.nblettres;
            int nblettres = c.Execute(delnb,"allo", "bonjour");
            Console.WriteLine(nblettres);
            try
            {
                c.TestException(200);
            }
            catch(OverflowException e) { }
            catch(Exception e) { // code a faire si plante avec cette exception
                                 }
        }

        // void Calculer(int a, int b)

      

    }
}
