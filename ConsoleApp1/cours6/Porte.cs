using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Porte
    {
        public bool ouvert {  get; set; } = false;

        public void ChangeEtat(Object sender)
        {
            if(sender is Bouton)
            {
                ouvert = !ouvert;
            }
            else { Console.WriteLine("shalut"); }
        }

        public Porte() { Console.WriteLine($"** {this.GetType().Name} : je me crée"); }
        public void afficher()
        {
            string temp;
            if (ouvert) {
                  temp = "ouvert";
            } else {
                     temp = "fermer";
              };
                Console.WriteLine($"je suis une porte et je suis {temp}");
        }
    }
}
