using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Partie
    {
        public int[] Points { get; private set; } = new int[2];
        public Joueur[] Joueurs { get; private set; } = new Joueur[6];
        public bool PartieFinie { get; private set; } = false;
        private static readonly Random rnd = new Random();

        public Partie(Joueur[] joueurs)
        {
            if (joueurs.Length != 6)
                throw new ArgumentException("Il faut exactement 6 joueurs");
            Joueurs = joueurs;
        }

        public void Lancer()
        {
            foreach (var j in Joueurs)
                j.SePlacer();

            while (!PartieFinie)
                JouerUnTour();
        }

        private void JouerUnTour()
        {
            if (PartieFinie) return;

            int index = rnd.Next(0, Joueurs.Length);
            Joueur joueurAvecBallon = Joueurs[index];
            joueurAvecBallon.PossessionBallon = true;
            Console.WriteLine("\n*** le ballon est lancé****");
            joueurAvecBallon.Attraper();

            Console.WriteLine("\n*** tout le monde se met à courir****");
            foreach (var j in Joueurs)
            {
                if (j != joueurAvecBallon)
                    j.Courrir(joueurAvecBallon.NoEquipe);
                else
                    Console.WriteLine($":équipe : {j.NoEquipe} {j.GetType().Name} je reste dans mon but");
            }

            if (!(joueurAvecBallon is Gardien))
            {
                Console.WriteLine($"et je lance le ballon");
            }
            if (joueurAvecBallon is Gardien gardien && !gardien.PossessionBallon)
            {
                int equipeAdverse = 1 - gardien.NoEquipe;
                Points[equipeAdverse]++;
                Console.WriteLine("\n*** oups un but ***");
                Console.WriteLine($"équipe 1 : {Points[0]} points");
                Console.WriteLine($"équipe 2 : {Points[1]} points");
            }
            if (Points[0] >= 2 || Points[1] >= 2)
            {
                PartieFinie = true;
                Console.WriteLine("\n.la partie est terminée");
                Console.WriteLine($"équipe 1 : {Points[0]} points");
                Console.WriteLine($"équipe 2 : {Points[1]} points");
                Console.WriteLine($".l'équipe {(Points[0] > Points[1] ? 1 : 2)} gagne");
            }

            joueurAvecBallon.PossessionBallon = false;
        }

    }
}
