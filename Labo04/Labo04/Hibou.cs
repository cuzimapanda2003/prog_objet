using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Labo04
{
    public class Hibou
    {

        public void Executer(Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        public void Executer(Action<string> action, string parametre)
        {
            if (action != null)
            {
                action(parametre);
            }
        }

        public string Executer(Func<string> fonction)
        {
            if (fonction != null)
            {
                return fonction();
            }
            return null;
        }

        public string Executer(Func<int, string> fonction, int parametre)
        {
            if (fonction != null)
            {
                return fonction(parametre);
            }
            return null;
        }
    }
}
