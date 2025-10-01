namespace tp01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maison maison = new Maison();
            Laveuse laveuse = new Laveuse();
            maison.la = laveuse;
            Console.WriteLine("Affichage initial de la maison :");
            maison.Affiche();
            Console.WriteLine();
            if (maison.p != null)
            {
                maison.pe.FaireTonLavage();
            }
            Console.WriteLine();
            Console.WriteLine("Affichage final de la maison :");
            maison.Affiche();
            Console.ReadLine();

        }
    }
}
