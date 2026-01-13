using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo04
{
    public class PorteTest : Porte
    {
        public override bool DebarrerPorte(string p)
        {
            OnTentativeDebarrer();

            return false;
        }
    }
}