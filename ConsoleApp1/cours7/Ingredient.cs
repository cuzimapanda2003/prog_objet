using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours7
{
    public class Ingredient
    {
        private string state;
        private string name;
        private string chaleur;

        public Ingredient() {
            state = "liquide";
            name = "huile";
            chaleur = "froid";
        }

        public Ingredient(string name, string state)
        {
            this.name = name;
            this.state = state;
            chaleur = "froid";
        }

        public void Afficher()
        {
            Console.WriteLine($"Je suis {name} et mon état est {state} et l'objet est {chaleur} ");
        }

        public string State {
            get { return state; }
            set {
                if (value == "gazeux" || value == "solide" || value == "liquide")
                {
                    state = value;
                }
            }
        }

        public string Name {get { return name; } set { name = value; } }

        public string Chaleur { get { return chaleur; } private set { chaleur = value; } }

        public void chauffer()
        {
            Console.WriteLine($"{name} ce chauffe");
            chaleur = "chaud";
            State = "liquide";
        }

    }
}
