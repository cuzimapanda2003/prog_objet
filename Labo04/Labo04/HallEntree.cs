using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class HallEntree
    {
        private Participant? participant = null;
        private List<Salle?>? salles = null;
        public Spectateurs? Spectateurs { get; set; } = new Spectateurs();

        public event Action? ApplaudissementsEvent;

        public HallEntree()
        {
            salles = new List<Salle?>()
            {
                new SalleTest(),
                new SalleDelegue(),
                new SalleException()
            };
        }

        protected virtual void OnApplaudissements()
        {
            ApplaudissementsEvent?.Invoke();
        }

        public void EntreeParticipant(Participant? participant)
        {
            Console.WriteLine(participant.Nom + " est notre participant!");
            this.participant = participant;

            Console.WriteLine("\n Le participant entre dans le hall...");
            OnApplaudissements();

            Console.WriteLine("\nLes épreuves commencent!");
            System.Threading.Thread.Sleep(2000);

            foreach (var salle in salles)
            {
                Console.WriteLine();
                Console.WriteLine(" vers la " + salle.Nom);
                Console.WriteLine("_____________________________");
                Console.WriteLine();
                string methodeName = "Epreuve_" + salle.Nom;
                MethodInfo m = participant.GetType().GetMethod(methodeName);
                m.Invoke(participant, new object[] { salle });

                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}