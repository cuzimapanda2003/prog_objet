using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class A
    {// connait 
        public void Calculer(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public  int nblettres(string s1, string s2)
        {
            int s = (s1 + s2).Length;
            Console.WriteLine("ici");
            return s;
        }
    }
}
