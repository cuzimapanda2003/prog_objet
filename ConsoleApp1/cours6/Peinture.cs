using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Peinture
    {
        public string nom {  get; set; } = string.Empty;

        public Peinture(string nom) { Console.WriteLine($"** {this.GetType().Name} : je me crée"); }


        public void afficher()
        {
            Console.WriteLine($"je suis une peinture et mon nom est {nom}");
        }


    }
}
