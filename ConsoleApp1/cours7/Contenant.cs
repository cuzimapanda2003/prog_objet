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

        public Ingredient? ingredient { get; set; } = null;

       public  Contenant() {
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

    }
}
