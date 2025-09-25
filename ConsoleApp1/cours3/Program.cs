namespace cours3
{
    public class Program
    {
        static void Main(string[] args)
        {
            voiture v1 = new voiture();
            v1.Affiche();
            voiture v2 = new voiture("verte");
            v2.Affiche();
            v1.Couleur = "orange";
            // oui il fallait ajouter une propriété pour an
            Console.WriteLine($" v1 :{v1.Couleur}  {v1.An}");

            // AfficheEnteteExercice(2);
            // tests de tous les cas possibles de la voiture 2
            voiture v3 = new voiture("JAUNE");
            Console.WriteLine(v3);//override ToString
            Console.WriteLine(" tests");
            Console.Write("Stop            :");
            v3.Stop();
            Console.Write("Avance          :");
            v3.Avance();
            Console.Write("Arrête   moteur :");
            v3.ArreterMoteur();
            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.Write("Faire le plein  :");
            v3.FairePlein();
            Console.Write("Faire le plein  :");
            v3.FairePlein();
            Console.Write("Avance          :");
            v3.Avance();
            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.WriteLine(v3);
            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.WriteLine(v3);
            Console.Write("Arrête   moteur :");
            v3.ArreterMoteur();
            Console.WriteLine(v3);

            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.WriteLine(v3);

            Console.WriteLine("Avance  10 fois  :");
            for (int i = 0; i < 10; i++)
            { Console.Write($"{i + 1}: "); v3.Avance(); }
            Console.WriteLine();
            Console.WriteLine(v3);
            Console.WriteLine();
            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.WriteLine(v3);
            Console.Write("Faire le plein  :");
            v3.FairePlein();
            Console.WriteLine(v3);
            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.Write("Avance          :");
            v3.Avance();
            Console.Write("Arrête   moteur :");
            v3.ArreterMoteur();
            Console.WriteLine(v3);
            Console.Write("Démarre moteur  :");
            v3.DemarrerMoteur();
            Console.Write("Avance          :");
            v3.Avance();
            Console.Write("Stop:");
            v3.Stop();
            Console.WriteLine(v3);
            Console.Write("Stop:");
            v3.Stop();
            Console.WriteLine(v3);
        }
    }
}
