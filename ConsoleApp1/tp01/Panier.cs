using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class Panier
    {
        public TasDeLinge? Tas { get; private set; }
        public void PrendLinge(TasDeLinge tas)
        {
            tas.Lieux = "Panier";
            Tas = tas;
        }
        public TasDeLinge? DonneLinge()
        {
            TasDeLinge? linge = Tas;
            Tas = null; 
            return linge;
        }

        public void Affiche()
        {
            Console.WriteLine(this.GetType().Name + " :");
            if (Tas == null)
            {
                Console.WriteLine("  null");
            }
            else
            {
                Tas.Affiche();
            }
        }

     }
}
