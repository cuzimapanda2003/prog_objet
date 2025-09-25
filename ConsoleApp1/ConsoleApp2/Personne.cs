using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours2
{
    public class Personne
    {
       private string nom = "blank";
       private int age = 1;

  //  propfull fait la variable + get set auto
       private string favColor;
    
        public string FavColor
        {
            get { return favColor="blue"; }
            set { favColor = value; }
        }






        public Personne() {

        }
        public Personne(string nom) {
            this.nom = nom;       
        }

        public Personne(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }


       public void affiche()
        {
            Console.WriteLine($"je m'appel {nom} et j'ai {age} ans");
        }

        public int GetAge() { 
        
        return age;
        
        }

        public string Nom{ 
        
            get { return nom; }
            set { nom = value; }   

        }

        public int Age
        {
            get { return age; }
            set {age = value; }
        }
    }
}
