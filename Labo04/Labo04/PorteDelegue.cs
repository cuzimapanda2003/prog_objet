using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class PorteDelegue : Porte
    {
        private string phrase = "Porte de salle Delegue ouvre-toi 5";
        public override bool DebarrerPorte(string p)
        {
            OnTentativeDebarrer();

            if (p == phrase)
            {
                Debarrer = true;
                return true;
            }
            return false;
        }
    }
}