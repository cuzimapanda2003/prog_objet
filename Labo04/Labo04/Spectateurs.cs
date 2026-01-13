using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class Spectateurs
    {
        public void Applaudir()
        {
            Console.WriteLine(" Les spectateurs applaudissent chaleureusement le participant! ");
        }

        public void EncouragerPorte(string nomPorte)
        {
            Console.WriteLine($" Spectateurs: \"Ouvre, {nomPorte}! Ouvre!\" ");
        }
    }
}