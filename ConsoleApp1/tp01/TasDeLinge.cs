using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class TasDeLinge
    {
        public string Lieux { get; set; }
        public string Couleur { get; set; }


        public TasDeLinge(string couleur)
        {
            Couleur = couleur;
            Lieux = "lit";
        }

        public void Affiche()
        {
            Console.WriteLine($"{this.GetType().Name} : {Couleur} {Lieux}");
        }


    }
}
