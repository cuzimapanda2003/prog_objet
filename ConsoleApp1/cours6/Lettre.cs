using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours6
{
    public class Lettre
    {
        private string password = string.Empty;
 
        private string secret = string.Empty;

        public Lettre(string secret, string password) {
            this.secret = secret;
            this.password = password;   
            Console.WriteLine($"** {this.GetType().Name} : je me crée");
        
        }

        public void afficher()
        {
            string temp;
            if (secret == string.Empty)
            {
                temp = "et je n'ai pas de secret";
            }
            else
            {
                temp = "et j'ai un secret";
            }
                Console.WriteLine($"je suis une lettre {temp}");
        }
    }
}
