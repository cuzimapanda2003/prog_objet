using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    public class CordeALinge
    {
        public TasDeLinge[] LesTas { get; set; } = new TasDeLinge[3];


        public void Affiche()
        {
            Console.WriteLine(this.GetType().Name + " :");
            for (int i = 0; i < LesTas.Length; i++)
            {
                if (LesTas[i] == null)
                {
                    Console.WriteLine($"  Case {i} : null");
                }
                else
                {
                    Console.Write($"  Case {i} : ");
                    LesTas[i]?.Affiche();
                }

            }
        }
    }
}
