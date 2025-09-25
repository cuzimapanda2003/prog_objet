namespace cours6
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Manoir manoir = new Manoir();
           // Peinture peinture = new Peinture();
           // Porte porte = new Porte();  
           // Bouton bouton = new Bouton();
           // Meuble meuble = new Meuble();
           // Tiroire tiroire = new Tiroire();
           // Lettre lettre = new Lettre();   


            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            //partie 1
          //  manoir.nom = "patrice";
           // manoir.afficher();
           // porte.afficher();
           // bouton.afficher();
           // meuble.afficher();
           // tiroire.afficher();
           // lettre.afficher();


            //partie 2

           Peinture peinture = new Peinture("paysage");
           Manoir manoir = new Manoir(peinture);
           Serviteur serv = new Serviteur();
           Meuble meuble = (Meuble)serv.creerMeuble();
   
         
  





        }
    }
}
