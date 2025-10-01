using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class Laveuse
    {
        private TasDeLinge? tas;
        public TasDeLinge? Tas
        {
            get { return tas; }
            set
            {
                tas = value;
            }
        }
        public TasDeLinge? DonneLinge()
        {
            TasDeLinge? linge = tas;
            tas = null;
            return linge;
        }
        public bool Rincage { get; set; } = false;
        public int Chaleur { get; set; } = 0;


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

            string eau = (Chaleur == 0) ? "eau froide" : "eau chaude";
            Console.WriteLine($"  {eau}, rinçage = {Rincage}");
        }

        public void Laver()
        {
            string eau = (Chaleur == 0) ? "eau froide" : "eau chaude";
            Console.WriteLine($"La laveuse lave avec {eau}.");

            if (Tas != null)
            {
                Console.WriteLine("Tas de linge dans la laveuse :");
                Tas.Affiche();
            }
            else
            {
                Console.WriteLine("Il n’y a rien à laver !");
            }

            if (Rincage)
            {
                Console.WriteLine("Rinçage effectué.");
            }
        }
    }
}
