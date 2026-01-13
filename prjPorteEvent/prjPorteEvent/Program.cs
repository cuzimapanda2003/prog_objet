using System.Runtime.InteropServices.ObjectiveC;

namespace prjPorteEvent
{
    internal class Program
    {   static void AfficheEtatPorte( Object sender, EventArgs e)// parms de ce gestionnaire d'événement
        {
            Console.WriteLine(  "la porte est ouverte");

        }
        static void AfficheEtatPorteAvecparm(Object sender, InfoPorteEventArgs e)// parms de ce gestionnaire d'événement
        {
            Console.WriteLine($"la porte  {e.numero} est fermée a {e.heure} "   );

        }
        static void Main(string[] args)
        {
           Porte unePorte=new Porte();

            unePorte.eventPorteOuvre += AfficheEtatPorte;
            unePorte.eventPorteFerme += AfficheEtatPorteAvecparm;

            unePorte.Ouvrir();

            unePorte.Ouvrir();
            unePorte.Ouvrir();
            unePorte.EstOuverte = false;
            unePorte.Ouvrir();





        }
    }
}
