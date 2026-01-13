using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Gardien : Joueur
    {
        private static readonly Random rnd = new Random();

        public override void SePlacer()
        {
            AfficherEquipe();
            Console.WriteLine("Gardien, je suis placé dans le but");
        }

        public override void Attraper()
        {
            AfficherEquipe();
            int but = rnd.Next(0, 2);
            if (but == 0)
            {
                Console.WriteLine("Gardien, j'attrape le ballon");
                PossessionBallon = true;
            }
            else
            {
                Console.WriteLine("Gardien, je laisse passer le ballon");
                PossessionBallon = false;
            }
        }

        public override void Courrir(int noEquipeAdverse)
        {
            AfficherEquipe();
            if (PossessionBallon)
                Console.WriteLine("Gardien, je reste dans mes buts et je lance le ballon");
            else
                Console.WriteLine("Gardien, je reste dans mes buts");
        }


    }
}
