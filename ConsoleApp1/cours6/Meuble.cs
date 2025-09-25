using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Meuble
    {
        public Tiroire? Tiroire { get; set; } = null;

        public Meuble() { Console.WriteLine($"** {this.GetType().Name} : je me crée"); }

        public void afficher()
        {
            Console.WriteLine("je suis un meuble");
            if (Tiroire != null) { Tiroire.afficher(); };
        }
    }
}
