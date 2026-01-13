using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Joueur
    {
        public int NoEquipe { get; set; }
        public bool PossessionBallon { get; set; } = false;

        public void AfficherEquipe()
        {
            Console.WriteLine($"Mon équipe est : {NoEquipe}");
        }

        public abstract void SePlacer();
        public abstract void Attraper();
        public abstract void Courrir(int noEquipeAdverse);
    }
}

      