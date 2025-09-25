using cours2;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("demo class personne");
            Personne p1;
            p1 = new Personne();
            p1.affiche();

            Personne p2 = new Personne("bob");
            p2.affiche();
            Personne p3 = new Personne("marcel", 27);      
            p3.affiche();

            Console.WriteLine(p2.Nom);
            Console.WriteLine(p2.Age);

            p1.Nom = p2.Nom + "ette";

            Console.WriteLine(p1.Nom);


        }
    }
}
