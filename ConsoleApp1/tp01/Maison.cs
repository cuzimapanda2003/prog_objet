using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class Maison
    {
        public TasDeLinge[] tdl { get; set; } = new TasDeLinge[2];
        public CordeALinge? cl { get; set; } = null;
        public Panier p { get; set; } = new Panier();
        public Laveuse? la { get; set; } = null;
        public Personne? pe { get; set; } = null;


        public Maison()
        {
            pe = new Personne(this);
            tdl[0] = new TasDeLinge("rouge");
            tdl[1] = new TasDeLinge("blanc");
        }


        public void Affiche()
        {
            Console.WriteLine(this.GetType().Name + " :");

            foreach (var tas in tdl)
            {
                tas.Affiche();
            }

            p.Affiche();

            if (la != null)
                la.Affiche();

            if (cl != null)
                cl.Affiche();
        }
    
    }
}
