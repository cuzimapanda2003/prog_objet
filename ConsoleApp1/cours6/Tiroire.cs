using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Tiroire
    {
        public Lettre? Lettre { get; set; } = null;

        public bool ouvert {  get; set; } = false;

        public Tiroire() {
            Console.WriteLine($"** {this.GetType().Name} : je me crée");
            Lettre = new Lettre("shalut", "123");
        }

        public void afficher()
        {

            string temp;
            if (ouvert)
            {
                temp = "ouvert";
            }
            else
            {
                temp = "fermer";
                ;
            }
                Console.WriteLine($"je suis un tiroire et je suis {temp}");
                if (Lettre != null) { Lettre.afficher(); }
            ;
        }
    }
}
