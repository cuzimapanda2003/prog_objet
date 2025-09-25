using cours4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours3
{
    public class voiture
    {
        private string couleur = "rouge";
        private int an = DateTime.Today.Year;
        // attributs (données, champs ) voiture2
        private int essence = 0;
        private float km = 0;
        private bool moteurOn = false;
        private float vitesse = 0;
        public radio radio = new radio();

        // méthodes, propriétés voiture1    
        public voiture() { }
        public voiture(string couleur)
        { this.couleur = couleur; }
        public string Couleur
        {
            get { return couleur; }
            set
            {
                value = value.ToUpper();
                if (value != "ORANGE") couleur = value;
            }
        }
        public int An
        {
            get { return an; }
            set
            {
                an = value;

            }
        }
        public void Affiche()
        { Console.WriteLine($"on: {radio.On}  poste: {radio.Poste} couleur: {couleur} an:{an} km:{km} moteur:{moteurOn}  vitesse:{vitesse} essence: {essence}"); }
        // méthodes, propriétés voiture2
        private void PanneEssence()
        {
            Console.WriteLine(" oups panne essence");
            ArreterMoteur();
        }
        public void DemarrerMoteur()
        {
            if (moteurOn)
            {
                Console.WriteLine("moteur déjà démarré");
                return;
            }
            if (essence <= 0)
            {
                Console.WriteLine(" je n'ai plus d'essence");
                return;
            }
            moteurOn = true;
            Console.WriteLine("vrom vrom");

            //*** sera à améliorer avec une propriété private
            essence--;

            if (essence <= 0)
            { PanneEssence(); }
        }

        public void ArreterMoteur()
        {
            if (moteurOn == false)
            {
                Console.WriteLine("moteur déjà arrêté");
                return;
            }

            Console.WriteLine("le moteur s'arrête");
            if (vitesse > 0) { Stop(); }

            moteurOn = false;

        }
        public void Stop()
        {
            if (vitesse <= 0)
            {
                Console.WriteLine("je n'avance pas!");
                return;
            }
            vitesse = 0;
            Console.WriteLine("Je stop");
            Console.WriteLine();
        }
        public void Avance()
        {
            if (moteurOn == false)
            {
                Console.WriteLine("moteur n'est pas démarré!");
                return;
            }
            if (essence <= 0)
            {
                Console.WriteLine("je n'ai plus d'essence!");
                return;
            }
            vitesse = 10;
            km++;
            essence--;
            Console.WriteLine(" j'avance");
            //*** sera à améliorer avec une propriété private

            if (essence <= 0)
            { PanneEssence(); }
            Console.WriteLine();
        }

        public void FairePlein()
        {
            if (vitesse > 0)
            {
                Stop();

            }
            if (moteurOn)
            {
                ArreterMoteur();
            }
            if (essence == 10)
            {
                Console.WriteLine("je suis déjà pleine!");
                return;
            }
            essence = 10;
            Console.WriteLine(" menoum menoum");

        }
        public override string ToString()
        {// au lieu de objet.Affiche()
            // cw(objet);
            return $"couleur: {couleur} an:{an} km:{km} moteur:{moteurOn}  vitesse:{vitesse} essence: {essence}";
        }


    }
}
