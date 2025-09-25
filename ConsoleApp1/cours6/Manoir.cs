using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Manoir
    {

 
        public Porte? Porte { get; set; } = null;
        public Bouton? Bouton { get; set; } = new Bouton(this);
        public Meuble? Meuble { get; set; } = null;
        public Peinture? Peinture { get; set; } = null;
        public string nom {  get; set; } = string.Empty;

      public Manoir() { Console.WriteLine($"** {this.GetType().Name} : je me crée"); }

        public Manoir(Peinture p)
        {
            Console.WriteLine($"** {this.GetType().Name} : je me crée");
            Peinture = p;
          
        }

        public void afficher()
        {
       
            Console.WriteLine($"je suis un manoir mon nom est {nom}");
            if (Porte != null) { Porte.afficher(); };
            if(Bouton != null) { Bouton.afficher(); };
            if (Meuble != null) { Meuble.afficher(); };
            if (Peinture != null) { Peinture.afficher(); };
         
        }


    }
}
