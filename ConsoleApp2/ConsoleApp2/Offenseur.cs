using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Offenseur : Joueur
    {
        public override void SePlacer()
        {
            AfficherEquipe();
            Console.WriteLine("Offenseur, je suis placé au centre");
        }

        public override void Attraper()
        {
            AfficherEquipe();
            Console.WriteLine("Offenseur, j'attrape le ballon");
            PossessionBallon = true;
        }

        public override void Courrir(int noEquipeAdverse)
        {
            AfficherEquipe();
            if (PossessionBallon)
                Console.WriteLine($"Offenseur, je cours vers le but de l'équipe {noEquipeAdverse} et je lance le ballon");
            else
                Console.WriteLine($"Offenseur, je cours vers le but de l'équipe {noEquipeAdverse}");
        }
    }

}

