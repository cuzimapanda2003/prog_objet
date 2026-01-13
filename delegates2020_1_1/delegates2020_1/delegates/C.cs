using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class C
    {
        public void Execute(Action<int, int> delc, int p1, int p2)
        {
            Console.WriteLine(" classe c je demande je ne sais pas quoi");
            delc.Invoke(p1, p2);
        }  //c.Calculer(x,y);

        public int Execute(Func<string, string, int> delL, string s1, string s2)
        {
            Console.WriteLine(" classe c je demande je ne sais pas quoi   encore");
            return delL.Invoke(s1, s2);
        }

        public void TestException(int nb)
        {
            if (nb >87) { throw new OverflowException("raté"); }
        }
    }

}
