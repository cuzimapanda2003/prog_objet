using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Serviteur
    {
        public Serviteur() { Console.WriteLine($"** {this.GetType().Name} : je me crée"); }



        public void AllerPorterMeuble(Manoir manoir, Meuble meuble)
        {

            if (!(manoir.Porte.ouvert))
            {
                manoir.Bouton.appuyer();
            }



        }

        public object creerMeuble()
        {
           Meuble meuble = new Meuble();
            meuble.Tiroire = new Tiroire();
            return meuble;
        }
    }



}
