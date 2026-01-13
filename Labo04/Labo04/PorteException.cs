using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class PorteException : Porte
    {
        private int code = 11;
        public override bool DebarrerPorte(string snd)
        {
            OnTentativeDebarrer();

            int nbi;
            if (Int32.TryParse(snd, out nbi))
            {
                if (nbi > code)
                {
                    throw new ArgumentOutOfRangeException("tropgrand");
                }
                if (nbi < code)
                {
                    throw new ArgumentOutOfRangeException("troppetit");
                }
                if (nbi == code)
                {
                    Console.WriteLine("oh oh oh ...");
                    Debarrer = true;
                    throw new AccessViolationException();
                }
            }
            else
            {
                throw new FormatException();
            }
            return false;
        }
    }
}