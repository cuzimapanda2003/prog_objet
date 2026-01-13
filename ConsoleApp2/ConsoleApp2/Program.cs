namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Joueur[] joueurs = new Joueur[6]
           {
                new Gardien { NoEquipe = 0 },
                new Gardien { NoEquipe = 1 },
                new Défenseur { NoEquipe = 0 },
                new Défenseur { NoEquipe = 1 },
                new Offenseur { NoEquipe = 0 },
                new Offenseur { NoEquipe = 1 }
           };

            Partie partie = new Partie(joueurs);
            partie.Lancer();



        }
    }
}
