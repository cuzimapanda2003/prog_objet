using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Bouton
    {
    

        public Bouton(Manoir manoir) {
            Console.WriteLine($"** {this.GetType().Name} : je me crée");
        }

        public void appuyer()
        {
       manoir?.Porte?.ChangeEtat(this);
           
        }

        public void afficher()
        {
            Console.WriteLine("je suis un bouton");
        }
    }
}
