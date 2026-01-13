using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Défenseur : Joueur
    {
        public override void SePlacer()
        {
            AfficherEquipe();
            Console.WriteLine("Defenseur, je suis placé derrière l’offenseur");
        }

        public override void Attraper()
        {
            AfficherEquipe();
            Console.WriteLine("Defenseur, j'attrape le ballon");
            PossessionBallon = true;
        }

        public override void Courrir(int noEquipeAdverse)
        {
            AfficherEquipe();
            if (PossessionBallon)
                Console.WriteLine($"Defenseur, je cours vers le but de l'équipe {noEquipeAdverse} et je lance le ballon");
            else
                Console.WriteLine($"Defenseur, je cours vers le but de l'équipe {noEquipeAdverse}");
        }
    }
}
