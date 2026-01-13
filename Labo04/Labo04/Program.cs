using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HallEntree hall = new HallEntree();
            Participant participant = new Participant();

            hall.ApplaudissementsEvent += hall.Spectateurs.Applaudir;

            SalleTest salleTest = new SalleTest();
            SalleDelegue salleDelegue = new SalleDelegue();
            SalleException salleException = new SalleException();

            salleTest.Porte.TentativeDebarrerEvent += hall.Spectateurs.EncouragerPorte;
            salleDelegue.Porte.TentativeDebarrerEvent += hall.Spectateurs.EncouragerPorte;
            salleException.Porte.TentativeDebarrerEvent += hall.Spectateurs.EncouragerPorte;

            hall.EntreeParticipant(participant);

            Console.WriteLine("\n\n Toutes les épreuves sont terminées! ");
            Console.ReadLine();
        }
    }
}