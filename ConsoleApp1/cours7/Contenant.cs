using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours7
{
    public class Contenant
    {
        private string type;
        private string greatness;

        public string color { get; } = "blanc";

        public Ingredient? ingredient
        {
            get { return _ingredient; }
            set
            {
                if (value == null)
                {
                    _ingredient = null;
                }
                else if (_ingredient == null)
                {
                    _ingredient = value;
                }
                else
                {
                    Console.WriteLine("Le contenant est déjà plein !");
                }
            }
        }

        private Ingredient? _ingredient = null;


        public Contenant() {
            type = "bowl";
            greatness = "small";
           
        }

        public Contenant(string couleur) : this()
        {
            color = couleur;
            type = "bowl";
            greatness = "small";
        }


        public void afficher()
        {

            if (ingredient != null)
            {
                Console.Write($"je suis un {type} qui est {greatness} et de couleur {color} ");
                ingredient.Afficher();
            }
            else
            {
                Console.WriteLine($"je suis un {type} qui est {greatness} et de couleur {color}");
            }
        }


        public Ingredient? DonneIngredient()
        {
            Ingredient? temp = ingredient; 
            ingredient = null;            
            return temp;                  
        }

        public void PrendIngredient()
        {
            if (ingredient == null) 
            {
                Console.WriteLine("Le contenant est vide !");
            }
            else
            {
                ingredient = null;
            }
        }


        public override string ToString()
        {
            string texte = $"contenant {color}";
            if (ingredient != null)
            { texte += $" {ingredient.Name} {ingredient.State} "; }
            return texte;
        }

    }
}
